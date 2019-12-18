﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using TagsCloudContainer.UI;

namespace TagsCloudContainer.RectanglesTransformer
{
    static class TransformerСalculations
    {
        public static Result<Size> GetOptimalSizeForImage(ICollection<Rectangle> rectangles, int indent)
        {
            if (rectangles.Count == 0)
                return Result.Fail<Size>("Empty rectangles list");
            var minTop = rectangles.Min(rect => rect.Top);
            var maxBottom = rectangles.Max(rect => rect.Bottom);
            var maxRight = rectangles.Max(rect => rect.Right);
            var minLeft = rectangles.Min(rect => rect.Left);
            var width = Math.Max(maxRight, -minLeft) * 2;
            var height = Math.Max(maxBottom, -minTop) * 2;
            return new Size(width + indent * 2, height + indent * 2);
        }

        public static Point GetCenter(Size size)
        {
            return new Point(size.Width / 2, size.Height / 2);
        }

        public static List<Rectangle> GetRectanglesWithOptimalLocation(IEnumerable<Rectangle> rectangles, Size offset)
        {
            return rectangles
                .Select(rectangle => new Rectangle(rectangle.Location + offset, rectangle.Size))
                .ToList();
        }
    }
}
