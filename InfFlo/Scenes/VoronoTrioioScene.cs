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
    public class VoronoTrioioScene : IScene
    {
        private bool automate = false;


        private readonly Random _random = new();
        private readonly HashSet<Vector2> _points = new();
        private readonly HashSet<LineSegment> _lines = new();

        private static readonly Color _setLineColor = Color.Green;
        private static readonly Color _setActiveLineColor = Color.CornflowerBlue;
        private static readonly Color _searchLineColor = Color.Magenta;


        private LineSegment _initialLine;
        private Vector2 _initialPoint;

        private LineSegment _secondLine;
        private LineSegment _secondLineShortest;
        private LineSegment _thirdLine;
        private LineSegment _thirdLineShortest;

        
        private HashSet<Vector2>.Enumerator _pointEnumerator;
        private HashSet<Vector2>.Enumerator _pointEnumerator2;

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
                composer.RenderLine(line.Start, line.End, Color.Green);
            
            composer.RenderLine(ref _initialLine, Color.CornflowerBlue);
            composer.RenderLine(ref _secondLine, Color.Red);
            composer.RenderLine(ref _thirdLine, Color.Red);
            
            
            ImGui.NewFrame();

            ImGui.Checkbox("Play", ref automate);

            if (automate || ImGui.Button("NEXT"))
            {
                GoToNextLine();
            }

            composer.RenderUI();
        }

        private void GoToNextLine()
        {
            // todo - Simo A - this will leave the last point hanging
            _initialPoint = _pointEnumerator.Current;
            if (!_pointEnumerator.MoveNext())
                return;

            var secondPoint = _pointEnumerator.Current;

            LineSegment shortestLine = new(_initialPoint, secondPoint);

            foreach (var point in _points)
            {
                if (point == _initialPoint) continue;

                var testLine = new LineSegment(_initialPoint, point);
                if (testLine.Length() < shortestLine.Length())
                    shortestLine = testLine;
            }

            _initialLine = shortestLine;

            Vector2 a = _initialLine.Start;
            Vector2 b = _initialLine.End;

            _secondLineShortest = new LineSegment(Vector2.Zero, new Vector2(10000, 10000));
            _thirdLineShortest = _secondLineShortest;
            
            
            foreach (var point in _points)
            {
                if (point == a || point == b) continue;

                _secondLine = new LineSegment(point, a);
                _thirdLine = new LineSegment(b, point);

                if (_secondLine.Length() + _thirdLine.Length() < _thirdLineShortest.Length() + _thirdLineShortest.Length())
                {
                    _secondLineShortest = _secondLine;
                    _thirdLineShortest = _thirdLine;
                }
                
            }


            _lines.Add(_initialLine);
            _lines.Add(_secondLineShortest);
            _lines.Add(_thirdLineShortest);
        }

        public void Unload()
        {
            // release assets and shit
        }


        private void GeneratePoints()
        {
            for (var x = 0; x < 800; x++)
            for (var y = 0; y < 450; y++)
                if (_random.Next(100) >= 99)
                    _points.Add(new Vector2(x * 8, y * 8));

            Console.WriteLine($"\t | Point Count = {_points.Count}");
        }
    }
}