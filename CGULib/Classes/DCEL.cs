using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CGULib.Classes
{
    public class DCEL<T> where T : VectorBase
    {
        string name;
        string description;

        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }

        List<HalfEdge<T>> halfEdgeRecord;
        List<T> vertexRecord;
        List<Face<T>> faceRecord;

        public List<HalfEdge<T>> HalfEdgeRecord { get => halfEdgeRecord; }
        public List<T> VertexRecord { get => vertexRecord; }
        public List<Face<T>> FaceRecord { get => faceRecord; }


        public DCEL(string name, string description, DCEL<T> dcel = null)
        {
            this.name = name;
            this.description = description;


            vertexRecord = new List<T>();
            halfEdgeRecord = new List<HalfEdge<T>>();
            faceRecord = new List<Face<T>>();

            if (dcel != null)
            {
                vertexRecord.AddRange(dcel.vertexRecord);
                halfEdgeRecord.AddRange(dcel.halfEdgeRecord);
                faceRecord.AddRange(dcel.faceRecord);
            }
        }

        public void AddHalfEdge(HalfEdge<T> edge) => halfEdgeRecord.Add(edge);
        public void RemoveHalfEdge(HalfEdge<T> edge) => halfEdgeRecord.Remove(edge);

        public void AddVertex(T vertex) => vertexRecord.Add(vertex);
        public void RemoveVertex(T vertex) => vertexRecord.Remove(vertex);

        public void AddFace(Face<T> face) => faceRecord.Add(face);
        public void RemoveFace(Face<T> face) => faceRecord.Remove(face);
    }
}
