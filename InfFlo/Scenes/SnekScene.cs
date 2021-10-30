// using System;
// using System.Collections.Generic;
// using System.Diagnostics;
// using System.Linq;
// using System.Numerics;
// using Emotion.Common;
// using Emotion.Graphics;
// using Emotion.Graphics.Text;
// using Emotion.IO;
// using Emotion.Platform.Implementation.GlfwImplementation.Native;
// using Emotion.Platform.Input;
// using Emotion.Primitives;
// using Emotion.Scenography;
// using ImGuiNET;
//
// namespace InfFlo.Scenes
// {
//     public class SnekScene : IScene
//     {
//         // Loaded assets
//         private DrawableFontAtlas _atlasUbuntuMonoSmall;
//         private DrawableFontAtlas _atlasUbuntuMonoBigg;
//         private AudioAsset[] _ripTunes;
//
//         // Scene-status-related shit
//         private bool _gameOver = false;
//         private readonly Stopwatch _updateTimer = new Stopwatch();
//         private readonly Random _random = new Random();
//
//         private readonly Vector3 _gameFieldPosition = new Vector3(0, 30, 0);
//         private readonly Vector2 _gameFieldSize = new Vector2(Engine.Renderer.Camera.GetWorldBoundingRect().Size.X, Engine.Renderer.Camera.GetWorldBoundingRect().Size.Y - 30);
//
//         // Snek bits and parts
//         private readonly List<Vector3> _cells = new List<Vector3>();
//         private readonly Vector2 _cellSize = new Vector2(10f);
//
//         // Game-y stuffs
//         private const byte StartingCellCount = 5;
//         private Vector3 _nibble = new Vector3(Engine.Renderer.Camera.GetWorldBoundingRect().Size.X / 2, Engine.Renderer.Camera.GetWorldBoundingRect().Size.Y / 2, 0);
//         private int _score;
//
//         // Control/Input
//         private Key? _activeDirection = null;
//         private Key? _newDirection = null;
//         private readonly Key[] _validDirections = {Key.A, Key.D, Key.W, Key.S};
//         private const short StepPeriodMs = 100;
//
//         public SnekScene()
//         {
//             for (byte i = 0; i < StartingCellCount; i++)
//             {
//                 _cells.Add(new Vector3(10, _cellSize.Y * (5 + i), 0));
//             }
//         }
//
//         public void Load()
//         {
//             _atlasUbuntuMonoSmall = Engine.AssetLoader.Get<FontAsset>("font/ubuntumono-r.ttf")!.GetAtlas(8);
//             _atlasUbuntuMonoBigg = Engine.AssetLoader.Get<FontAsset>("font/ubuntumono-r.ttf")!.GetAtlas(64);
//
//             _ripTunes = new[]
//             {
//                 Engine.AssetLoader.Get<AudioAsset>("Assets/Sound/wasted_bell_0.wav"),
//                 Engine.AssetLoader.Get<AudioAsset>("Assets/Sound/wasted_bell_1.wav"),
//                 Engine.AssetLoader.Get<AudioAsset>("Assets/Sound/wasted_bell_2.wav"),
//             };
//         }
//
//         public void Update()
//         {
//             if (_gameOver) return;
//
//             UpdateDirection();
//             if (_newDirection != null) _updateTimer.Start();
//
//             if (_updateTimer.ElapsedMilliseconds < StepPeriodMs) return;
//             
//             _updateTimer.Restart();
//             DoStep();
//         }
//
//         private void DoStep()
//         {
//             _activeDirection = _newDirection;
//
//             for (int i = 0; i < _cells.Count; i++)
//             {
//                 if (i < _cells.Count - 1) // if not last cell
//                 {
//                     // move to position of next cell
//                     _cells[i] = _cells[i + 1];
//                 }
//                 else // is last cell -> move to new position
//                 {
//                     var cell = _cells[i];
//                     // ReSharper disable once SwitchStatementMissingSomeCases - I don't really need to _explicitly_ ignore the rest of the keyboard.
//                     switch (_activeDirection)
//                     {
//                         case Glfw.KeyCode.A:
//                             cell.X -= _cellSize.X;
//                             break;
//                         case Glfw.KeyCode.D:
//                             cell.X += _cellSize.X;
//                             break;
//                         case Glfw.KeyCode.W:
//                             cell.Y -= _cellSize.Y;
//                             break;
//                         case Glfw.KeyCode.S:
//                             cell.Y += _cellSize.Y;
//                             break;
//                     }
//
//                     _cells[i] = cell;
//                 }
//             }
//
//             CheckForHostileCollision();
//             CheckForNibbleCollision();
//         }
//
//         private void CheckForNibbleCollision()
//         {
//             if (_cells.Last() == _nibble)
//             {
//                 _cells.Insert(0, _cells[0]);
//                 _score++;
//                 RegenerateNibble();
//             }
//         }
//
//         private void RegenerateNibble()
//         {
//             // TODO - Simo Andreev - 08.10.2019 - coul produce a non-nommable niblle - e.g. if selected (maxBound - _cellSize.X) is not divisible by size for instance
// //            var x = _random.Next((int) (Engine.Renderer.BaseTarget.Size.X - _cellSize.X));
// //            var y = _random.Next((int) (Engine.Renderer.BaseTarget.Size.X - _cellSize.X));
//
//             var xPositionCount = (int) Math.Floor(_gameFieldSize.X / _cellSize.X);
//             var yPositionCount = (int) Math.Floor(_gameFieldSize.Y / _cellSize.Y);
//
//             var x = _random.Next(xPositionCount) * _cellSize.X + _gameFieldPosition.X;
//             var y = _random.Next(yPositionCount) * _cellSize.Y + _gameFieldPosition.Y;
//
//             _nibble = new Vector3(x, y, 0);
//         }
//
//         private void UpdateDirection()
//         {
//             foreach (var keyCode in _validDirections)
//             {
//                 if (keyCode == _activeDirection || keyCode == _newDirection) continue; // If the input is the same as the current direction -> no need to do anything
//
//                 // TODO - Simo Andreev - 08.09.2019 - NOTE - this prioritises input based on listing order in [_validDirections] 
//                 if (!Engine.Host.IsKeyDown(keyCode)) continue;
//
//                 if (IsReverseOfActive(keyCode)) continue; // U-turns in place are not allowed
//
//                 // All conditions passed - assign key to be future _activeDirection (possibly)
//                 _newDirection = keyCode;
//                 return;
//             }
//         }
//
//         private bool IsReverseOfActive(Key keyCode)
//         {
//             if (_activeDirection == null || keyCode == _activeDirection) return false;
//
//             return _activeDirection switch
//             {
//                 Key.A => (keyCode == Key.D),
//                 Key.D => (keyCode == Key.A),
//                 Key.W => (keyCode == Key.S),
//                 Key.S => (keyCode == Key.W),
//                 _ => false
//             };
//         }
//
//         private void CheckForHostileCollision()
//         {
//             var head = _cells.Last();
//
//             if (head.X < _gameFieldPosition.X || head.Y < _gameFieldPosition.Y || head.X + _cellSize.X > _gameFieldPosition.X + _gameFieldSize.X ||
//                 head.Y + _cellSize.Y > _gameFieldPosition.Y + _gameFieldSize.Y)
//             {
//                 _gameOver = true;
//                 Engine.Audio.GetLayer("default").PlayNext(_ripTunes[_random.Next(_ripTunes.Length)]);
//                 return;
//             }
//
//             // Can't bite yer arse if you're less than 5 blocks/cells long. (Would require turns of over 90° to do so and in _our_ world those don't exist')                     //also -conveniently- allows me to start with 1-to-4 'stacked' cells
//             if (_cells.Count <= 4) return;
//
//             // Check for each-but-the-last cell
//             for (var i = 0; i < _cells.Count - 1; i++)
//             {
//                 if (_cells[i] != _cells.Last()) continue;
//                 
//                 _gameOver = true;
//                 Engine.Audio.GetLayer("default").PlayNext(_ripTunes[_random.Next(_ripTunes.Length)]);
//                 return;
//             }
//         }
//
//
//         public void Draw(RenderComposer composer)
//         {
//             RenderGui();
//
//             Engine.Renderer.RenderOutline(_gameFieldPosition, _gameFieldSize, Color.White);
// //            Engine.Renderer.RenderString(_atlasUbuntuMonoSmall, $"active: {_activeDirection} | new: {_newDirection}", new Vector3(_gameFieldSize.X-120, 0, 0), Color.Green);
// //            Engine.Renderer.RenderString(_atlasUbuntuMonoSmall, $"Score: {_score}", Vector3.Zero, Color.Green);
//
//             // IRenderable
//             Engine.Renderer.Render(_nibble, _cellSize, Color.FromNonPremultiplied(192, 82, 57, 255));
//
//             foreach (var cell in _cells)
//             {
//                 Engine.Renderer.Render(cell, _cellSize, Color.Green);
//                 Engine.Renderer.RenderOutline(cell, _cellSize, Color.Black, 1f);
//             }
//
//             if (_gameOver)
//             {
//                 _updateTimer.Stop();
//                 Engine.Renderer.RenderString(_atlasUbuntuMonoBigg, "WASTED", new Vector3(200f), Color.Red);
//             }
//         }
//
//         private void RenderGui()
//         {
//             ImGui.NewFrame();
//             ImGui.Begin("", ImGuiWindowFlags.NoDecoration | ImGuiWindowFlags.NoMove | ImGuiWindowFlags.NoMouseInputs);
//             ImGui.SetWindowPos(Vector2.Zero);
//             ImGui.PushStyleVar(ImGuiStyleVar.WindowMinSize, Vector2.One);
//             ImGui.PushStyleVar(ImGuiStyleVar.WindowPadding, new Vector2(15, 6));
//             ImGui.SetWindowSize(new Vector2(Engine.Renderer.Camera.Width, 28));
//             ImGui.Columns(2);
//             ImGui.Text($"Score: {_score}");
//             ImGui.NextColumn();
//             ImGui.Text($"Input Info: active - {_activeDirection} | new - {_newDirection}");
//             Engine.Renderer.RenderGui();
//         }
//
//         public override void Unload()
//         {
//             Engine.AssetLoader.Destroy("font/ubuntumono-r.ttf");
//             Engine.AssetLoader.Destroy("sicbeats/wasted_bell_0.wav");
//             Engine.AssetLoader.Destroy("sicbeats/wasted_bell_1.wav");
//             Engine.AssetLoader.Destroy("sicbeats/wasted_bell_2.wav");
//         }
//     }
// }