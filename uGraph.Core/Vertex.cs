﻿using System;
using System.Collections.Generic;

namespace uGraph.Core
{
    public class Vertex<TVertex, TEdge>
    {
        public Guid Id { get; private set; }

        public TVertex Info { get; set; }

        public List<Edge<TVertex,TEdge>> Edges { get; private set; }

        internal bool Visited { get; set; }

        internal Vertex()
        {
            Id = Guid.NewGuid();
            Edges = new List<Edge<TVertex, TEdge>>();
            Visited = false;
        }
    }
}
