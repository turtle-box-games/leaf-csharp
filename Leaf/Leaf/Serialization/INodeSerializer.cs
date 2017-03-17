﻿using Leaf.Nodes;

namespace Leaf.Serialization
{
    /// <summary>
    /// Redirection to latest node serializer.
    /// This interface is used so that nodes can reference this interface instead of the latest,
    /// which would change every time there's a new version.
    /// </summary>
    internal interface INodeSerializer : IVersion1NodeSerializer
    {
        /// <summary>
        /// Reads a node given its type.
        /// </summary>
        /// <param name="type">Node type to read.</param>
        /// <returns>Read node type.</returns>
        Node ReadNode(NodeType type);
    }
}