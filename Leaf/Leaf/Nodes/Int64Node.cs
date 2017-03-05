﻿using System;
using System.IO;

namespace Leaf.Nodes
{
    /// <summary>
    /// Large integer value that can be stored.
    /// Stores a value from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 (64-bit).
    /// </summary>
    public class Int64Node : Node
    {
        /// <summary>
        /// Retrieve the ID for the type of node.
        /// This can be used to identify, serialize, and cast a node to its type.
        /// The value returned by this property is <see cref="NodeType.Int64"/>.
        /// </summary>
        public override NodeType Type => NodeType.Int64;

        /// <summary>
        /// Gets and sets the value of the node.
        /// </summary>
        public long Value { get; set; }

        /// <summary>
        /// Creates a new node.
        /// </summary>
        /// <param name="value">Value of the node.</param>
        public Int64Node(long value)
        {
            Value = value;
        }

        /// <summary>
        /// Creates a new node by reading its contents from a stream.
        /// </summary>
        /// <param name="reader">Reader used to pull data from the stream.</param>
        /// <returns>Newly constructed node.</returns>
        internal Int64Node Read(BinaryReader reader)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Writes the contents of the node to a stream.
        /// </summary>
        /// <param name="writer">Writer used to put data in the stream.</param>
        internal override void Write(BinaryWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}