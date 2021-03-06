﻿using Leaf.Nodes;

namespace Leaf.Serialization
{
    /// <summary>
    /// Capability to serialize all version 1 node types.
    /// </summary>
    internal interface IVersion1NodeWriter
    {
        /// <summary>
        /// Serialize a flag node.
        /// </summary>
        /// <param name="node">Node to serialize.</param>
        void Write(FlagNode node);

        /// <summary>
        /// Serialize a integer-8 node.
        /// </summary>
        /// <param name="node">Node to serialize.</param>
        void Write(Int8Node node);

        /// <summary>
        /// Serialize a integer-16 node.
        /// </summary>
        /// <param name="node">Node to serialize.</param>
        void Write(Int16Node node);

        /// <summary>
        /// Serialize a integer-32 node.
        /// </summary>
        /// <param name="node">Node to serialize.</param>
        void Write(Int32Node node);

        /// <summary>
        /// Serialize a integer-64 node.
        /// </summary>
        /// <param name="node">Node to serialize.</param>
        void Write(Int64Node node);

        /// <summary>
        /// Serialize a float-32 node.
        /// </summary>
        /// <param name="node">Node to serialize.</param>
        void Write(Float32Node node);

        /// <summary>
        /// Serialize a float-64 node.
        /// </summary>
        /// <param name="node">Node to serialize.</param>
        void Write(Float64Node node);

        /// <summary>
        /// Serialize a string node.
        /// </summary>
        /// <param name="node">Node to serialize.</param>
        void Write(StringNode node);

        /// <summary>
        /// Serialize a time node.
        /// </summary>
        /// <param name="node">Node to serialize.</param>
        void Write(TimeNode node);

        /// <summary>
        /// Serialize a UUID node.
        /// </summary>
        /// <param name="node">Node to serialize.</param>
        void Write(UuidNode node);

        /// <summary>
        /// Serialize a blob node.
        /// </summary>
        /// <param name="node">Node to serialize.</param>
        void Write(BlobNode node);

        /// <summary>
        /// Serialize a list node.
        /// </summary>
        /// <param name="node">Node to serialize.</param>
        void Write(ListNode node);

        /// <summary>
        /// Serialize a composite node.
        /// </summary>
        /// <param name="node">Node to serialize.</param>
        void Write(CompositeNode node);
    }
}