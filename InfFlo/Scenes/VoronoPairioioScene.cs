using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Emotion.Common;
using Emotion.Graphics;
using Emotion.Plugins.ImGuiNet;
using Emotion.Primitives;
using Emotion.Scenography;
using ImGuiNET;
using InfFlo.Util.Models;

namespace InfFlo.Scenes
{
    public class VoronoPairioioScene : IScene
    {
        private bool _automate = false;


        private readonly Random _random = new();
        private readonly HashSet<Vector2> _points = new();
        private readonly HashSet<LineSegment> _lines = new();

        private static readonly Color _lineColor = Color.Green;
        private HashSet<Vector2>.Enumerator _pointEnumerator;

        public void Load()
        {
            // load assets and shit
            Console.WriteLine($"\t | X: {Engine.Host.Size.X} | \t Y: {Engine.Host.Size.Y}");

            GeneratePoints();
            _pointEnumerator = _points.GetEnumerator();
        }


        public void Update()
        {
            // update stata
        }

        public void Draw(RenderComposer composer)
        {
            // render points
            foreach (var point in _points)
                composer.RenderCircle(new Vector3(point.X - 1, point.Y - 1, 40f), 1, Color.CornflowerBlue);


            foreach (var line in _lines)
                composer.RenderArrow(line.Start, line.End, _lineColor);


            ImGui.NewFrame();

            ImGui.Checkbox("Play", ref _automate);

            if (_automate || ImGui.Button("NEXT"))
            {
                GoToNextLine();
            }

            composer.RenderUI();
        }

        private void GoToNextLine()
        {
            var initialPoint = _pointEnumerator.Current;
            if (!_pointEnumerator.MoveNext())
                return;

            var secondPoint = _pointEnumerator.Current;

            LineSegment shortestLine = new(initialPoint, secondPoint);

            foreach (var point in _points)
            {
                if (point == initialPoint) continue;

                var testLine = new LineSegment(initialPoint, point);
                if (testLine.Length() < shortestLine.Length())
                    shortestLine = testLine;
            }
            
            _lines.Add(shortestLine);
        }

        public void Unload()
        {
            // release assets and shit
        }


        private void GeneratePoints()
        {
            for (var x = 0; x < 400; x++)
            for (var y = 0; y < 225; y++)
                if (_random.Next(100) >= 99)
                    _points.Add(new Vector2(x * 8, y * 8));

            Console.WriteLine($"\t | Point Count = {_points.Count}");
        }
    }
}