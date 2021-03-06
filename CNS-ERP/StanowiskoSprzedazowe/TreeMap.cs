﻿using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace StanowiskoSprzedazowe.TreeMap
{
    public class ChildAndRect
    {
        public UIElement Element { get; set; }
        public Rect Rectangle { get; set; }
    }

    public class TreeMap : Panel
    {
        private static FrameworkPropertyMetadata weightMetadata =
            new FrameworkPropertyMetadata(1.0,
                FrameworkPropertyMetadataOptions.AffectsParentArrange);

        public static readonly DependencyProperty WeightProperty =
            DependencyProperty.RegisterAttached("Weight", typeof(double),
                typeof(TreeMap), weightMetadata);

        public static void SetWeight(DependencyObject depObj, double value)
        {
            depObj.SetValue(WeightProperty, value);
        }

        // Measure phase
        protected override Size MeasureOverride(Size availableSize)
        {
            double totalWeight = totalChildWeight();

            foreach (ChildAndRect child in ChildrenTreemapOrder(InternalChildren.Cast<UIElement>(), availableSize))
                child.Element.Measure(child.Rectangle.Size);

            return availableSize;
        }

        // Arrange phase
        protected override Size ArrangeOverride(Size finalSize)
        {
            foreach (ChildAndRect child in ChildrenTreemapOrder(InternalChildren.Cast<UIElement>(), finalSize))
                child.Element.Arrange(child.Rectangle);

            return finalSize;
        }

        private double totalChildWeight()
        {
            double weightSum = 0;
            foreach (UIElement elem in InternalChildren)
                weightSum += (double)elem.GetValue(WeightProperty);

            return weightSum;
        }

        /// <summary>
        /// Return child elements orderd by weight (largest to
        /// smallest), passing back Rect for each child
        /// (size and location), implementing a (crude)
        /// treemap.
        /// </summary>
        /// <param name="elems">Child elements to measure/arrange</param>
        /// <param name="containerSize">Available container size</param>
        /// <returns></returns>
        private IEnumerable<ChildAndRect> ChildrenTreemapOrder(IEnumerable<UIElement> elems, Size containerSize)
        {
            double remainingWeight = totalChildWeight();

            double top = 0.0;
            double left = 0.0;

            // Alternate between left edge and top edge
            bool leftEdge;

            // Sort by weight
            var childrenByWeight = elems.OrderByDescending(
                e => (double)e.GetValue(WeightProperty));

            // Allocate space for each child, one at a time.
            // Moving left to right, top to bottom
            foreach (var child in childrenByWeight)
            {
                leftEdge = (containerSize.Width - left) > (containerSize.Height - top);

                Size size;

                double childWeight = (double)child.GetValue(WeightProperty);
                double pctArea = childWeight / remainingWeight;
                remainingWeight -= childWeight;

                // Entire height, proportionate width
                if (leftEdge)
                    size = new Size(pctArea * (containerSize.Width - left), containerSize.Height - top);

                // Top edge - Entire width, proportionate height
                else
                    size = new Size(containerSize.Width - left, pctArea * (containerSize.Height - top));

                yield return new ChildAndRect { Element = child, Rectangle = new Rect(new Point(left, top), size) };

                if (leftEdge)
                    left += size.Width;
                else
                    top += size.Height;
            }
        }
    }
}
