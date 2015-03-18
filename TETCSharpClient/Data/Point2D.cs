﻿/*
 * Copyright (c) 2013-present, The Eye Tribe. 
 * All rights reserved.
 *
 * This source code is licensed under the BSD-style license found in the LICENSE file in the root directory of this source tree. 
 *
 */

using System;

namespace TETCSharpClient.Data
{
    /// <summary>
    /// A 2D coordinate with double precision.
    /// </summary>
    public class Point2D
    {
        protected double x;
        protected double y;

        public static readonly Point2D zero = new Point2D();

        public Point2D()
        {
            x = 0;
            y = 0;
        }

        public Point2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Point2D(Point2D point)
        {
            x = point.x;
            y = point.y;
        }

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public override bool Equals(Object o)
        {
            if (ReferenceEquals(this, o))
                return true;

            if (!(o is Point2D))
                return false;

            var other = o as Point2D;

            return Double.Equals(x, other.x) && Double.Equals(y, other.y);
        }

        public override int GetHashCode()
        {
            int hash = 571;
            hash = hash * 2777 + X.GetHashCode();
            hash = hash * 2777 + Y.GetHashCode();
            return hash;
        }

        public static Point2D operator +(Point2D point1, Point2D point2)
        {
            return new Point2D { x = point1.x + point2.x, y = point1.y + point2.y };
        }

        public static Point2D operator -(Point2D point1, Point2D point2)
        {
            return new Point2D { x = point1.x - point2.x, y = point1.y - point2.y };
        }

        public static Point2D operator -(Point2D point1)
        {
            return new Point2D(-point1.x, -point1.y);
        }

        public static Point2D operator *(Point2D point1, Point2D multi)
        {
            return new Point2D { x = point1.x * multi.x, y = point1.y * multi.y };
        }

        public static Point2D operator *(Point2D point1, double k)
        {
            return new Point2D(point1.x * k, point1.y * k);
        }

        public static Point2D operator /(Point2D point1, double k)
        {
            return new Point2D(point1.x / k, point1.y / k);
        }

        public Point2D Add(Point2D p2)
        {
            return new Point2D(x + p2.x, y + p2.y);
        }

        public Point2D Subtract(Point2D p2)
        {
            return new Point2D(x - p2.x, y - p2.y);
        }

        public Point2D Multiply(int k)
        {
            return new Point2D(x * k, y * k);
        }

        public Point2D Divide(int k)
        {
            return new Point2D(x / k, y / k);
        }

        public Point2D Multiply(double k)
        {
            return new Point2D(x * k, y * k);
        }

        public Point2D Divide(double k)
        {
            return new Point2D(x / k, y / k);
        }

        public double Average()
        {
            return (x + y) / 2;
        }

        public override String ToString()
        {
            return "{" + x + ", " + y + "}";
        }
    }
}