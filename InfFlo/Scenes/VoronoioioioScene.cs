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

namespace InfFlo.Scenes
{
    public class VoronoioioioScene : IScene
    {
        private bool automate = false;

        private readonly Random _random = new Random();
        private List<Vector2> _points = new();
        private List<LineSegment> _lines = new();

        private LineSegment lineToRemove;
        private LineSegment lineThatRemovedIt;

        public void Load()
        {
            // load assets and shit
            Console.WriteLine($"\t | X: {Engine.Host.Size.X} | \t Y: {Engine.Host.Size.Y}");

            for (var x = 0; x < 160; x++)
            for (var y = 0; y < 90; y++)
                if (_random.Next(100) >= 99)
                    _points.Add(new Vector2(x * 8, y * 8));

            Console.WriteLine($"\t | Point Count = {_points.Count}");

            for (var i = 0; i < _points.Count; i++)
            for (var j = i + 1; j < _points.Count; j++)
                _lines.Add(new LineSegment(_points[i], _points[j]));

            var dupeIndexesToRemove = new HashSet<int>();
            for (var i = 0; i < _points.Count; i++)
            for (var j = i + 1; j < _points.Count; j++)
            {
                var line1 = _lines[i];
                var line2 = _lines[j];
                if ((line1.Start == line2.Start && line1.End == line2.End)
                    || (line1.Start == line2.End && line1.End == line2.Start))
                    dupeIndexesToRemove.Add(j);
            }


            var finalLines = _lines.Where((_, i) => !dupeIndexesToRemove.Contains(i)).ToList();
            // _lines = finalLines;
            _lines = finalLines.OrderBy(segment => segment.Length()).ToList();
        }

        public void Update()
        {
            // update stata
        }

        public void Draw(RenderComposer composer)
        {
            // render shit
            foreach (var point in _points)
                // composer.RenderCircle(new Vector3(point.X - 1, point.Y - 1, 40f), 1, Color.CornflowerBlue);
                composer.RenderCircle(new Vector3(point.X - 1, point.Y - 1, 40f), 1, Color.CornflowerBlue);
            foreach (var line in _lines)
            {
                if (line == lineToRemove)
                    composer.RenderLine(new Vector3(line.Start, 10f), new Vector3(line.End, 10f), Color.Red, 3f);
                else if (line == lineThatRemovedIt)
                    composer.RenderLine(new Vector3(line.Start, 20f), new Vector3(line.End, 20f), Color.Green, 2f);
                else
                    composer.RenderLine(new Vector3(line.Start, 0f), new Vector3(line.End, 0f), Color.Pink, 1f);
            }

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
            _lines.Remove(lineToRemove);
            bool foundIntersect = false;

            for (var i = 0; i < _lines.Count; i++)
            {
                for (var j = i + 1; j < _lines.Count; j++)
                {
                    var line1 = _lines[i];
                    var line2 = _lines[j];

                    //TODO - check for duplicates

                    if (line1.Start == line2.Start)
                        continue;
                    if (line1.Start == line2.End)
                        continue;
                    if (line1.End == line2.Start)
                        continue;
                    if (line1.End == line2.End)
                        continue;
                    if (!line1.Intersects(ref line2))
                        continue;

                    foundIntersect = true;
                    if (line1.Length() > line2.Length())
                    {
                        lineToRemove = line1;
                        lineThatRemovedIt = line2;
                    }
                    else
                    {
                        lineToRemove = line2;
                        lineThatRemovedIt = line1;
                    }

                    break;
                }

                if (foundIntersect) break;
            }
        }

        public void Unload()
        {
            // release assets and shit
        }
    }
}