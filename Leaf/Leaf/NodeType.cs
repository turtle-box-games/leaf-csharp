﻿namespace Leaf
{
    /// <summary>
    /// Numerical identifier specifying a node's type.
    /// </summary>
    public enum NodeType
    {
        /// <summary>
        /// Not an actual node type.
        /// Symbolizes the end of a node collection.
        /// </summary>
        End = 0x00,

        #region Version 1

        /// <summary>
        /// Boolean value.
        /// </summary>
        Flag = 0x01,

        /// <summary>
        /// One byte value ranging from 0 to 255.
        /// </summary>
        Int8 = 0x02,

        /// <summary>
        /// Signed integer stored in 16 bits.
        /// </summary>
        Int16 = 0x03,

        /// <summary>
        /// Signed integer stored in 32 bits.
        /// </summary>
        Int32 = 0x04,

        /// <summary>
        /// Signed integer stored in 64 bits.
        /// </summary>
        Int64 = 0x05,

        /// <summary>
        /// Single-precision floating-point number stored in 32 bits.
        /// </summary>
        Float32 = 0x06,

        /// <summary>
        /// Double-precision floating-point number stored in 64 bits.
        /// </summary>
        Float64 = 0x07,

        /// <summary>
        /// UTF-8 text.
        /// </summary>
        String = 0x08,

        /// <summary>
        /// Date and time value.
        /// </summary>
        Time = 0x09,

        /// <summary>
        /// Universally unique identifier.
        /// </summary>
        Uuid = 0x0a,

        /// <summary>
        /// Arbitrary binary data.
        /// </summary>
        Blob = 0x0b,

        /// <summary>
        /// Collection of nodes with the same type.
        /// </summary>
        List = 0x0c,

        /// <summary>
        /// Collection of nodes with names and any combination of types.
        /// </summary>
        Composite = 0x0d,

        #endregion

        #region Version 2

        /// <summary>
        /// Color information with red, green, blue, and alpha channels.
        /// </summary>
        Color = 0x0e,

        /// <summary>
        /// Two-dimensional point using integers.
        /// </summary>
        Point2 = 0x0f,

        /// <summary>
        /// Three-dimensional point using integers.
        /// </summary>
        Point3 = 0x10,

        /// <summary>
        /// Four-dimensional point using integers.
        /// </summary>
        Point4 = 0x11,

        /// <summary>
        /// Two-dimensional point using floating-point values.
        /// </summary>
        Vector2 = 0x12,

        /// <summary>
        /// Three-dimensional point using floating-point values.
        /// </summary>
        Vector3 = 0x13,
        
        /// <summary>
        /// Four-dimensional point using floating-point values.
        /// </summary>
        Vector4 = 0x14,

        /// <summary>
        /// Two-dimensional size and position using integers.
        /// </summary>
        Rect2 = 0x15,

        /// <summary>
        /// Three-dimensional size and position using integers.
        /// </summary>
        Rect3 = 0x16,

        /// <summary>
        /// Two-dimensional size and position using floating-point values.
        /// </summary>
        Bounds2 = 0x17,

        /// <summary>
        /// Three-dimensional size and position using floating-point values.
        /// </summary>
        Bounds3 = 0x18

        #endregion
    }
}
