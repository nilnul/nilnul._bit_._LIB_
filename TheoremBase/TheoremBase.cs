using System;
using OR;
using System.Collections;

namespace TheoremBase
{
	//public delegate bool Proposition(Graph g);
	public class Theorem1
	{
		public Graph g;
		public Theorem1(Graph g){
			this.g=g;
		}
		//for any graph, the total degrees of all vertexes is 2 times of the number of edges
		// in put graph, 
		///conclusion, the degrees of all vertexes's degree is ...
		///proof:
		///
		
		
		
		
//		public static void Theorem3(Proposition p){
//			p=new Proposition(TheoremBase.Proposition1);	//supposed.
//
//			///proof
//			///
//			Graph g;
//
//			
//			int totalDegree=0;
//			int totalEdge2=2*g.edges.Length;
//			for(int i=0;i<g.vertexes.Length;i++)
//			{
//				totalDegree+=g.degree(i);
//				///Propostion:every edge has two vertex.
//				totalEdge2--;
//				totalEdge2--;
//			}
//
//			
//
//			
//			
//
//			///return
//
//			return true;
//
//		}


		/// <summary>
		/// this is a propostion.
		/// </summary>
		/// <param name="g"></param>
		/// <returns></returns>
		public  bool Proposition()
		{
		
			int totalDegree=0;
			for(int i=0;i<g.vertexes.Length;i++)
			{
				totalDegree+=g.degree(i);
			}
			

			return totalDegree==2*g.edges.Length;

		}
		public bool Proof(){

			int totalDegree=0;
			int totalEdge2=2*g.edges.Length;
			for(int i=0;i<g.vertexes.Length;i++)
			{
				totalDegree+=g.degree(i);
				///Propostion:every edge has two vertex.
				totalEdge2--;
				totalEdge2--;
			}
///foreach deg(v)=0, exclude from the following computation.
			
			int totalDegByEdge;
			for(int i=0;i<g.edges.Length;i++){


			}


		}

	
	

		
	}//class

	public class Theorem2{

		public Graph g;

		public Theorem2(Graph g){
			this.g=g;
		}


		public bool Proposition()
		{
			int oddDegVertexCount=0;
			for(int i=0;i<g.vertexes.Length;i++)
			{
				if(g.degree(i)%2==1) oddDegVertexCount++;
			}
			return oddDegVertexCount%2==0;
		}
		public bool Proof(){
		
			ArrayList vOdd;
			ArrayList vEven;
			foreach(Vertex v in g.vertexes)
			{
				if(g.degree(v)%2==0) vEven.Add(v);
				else vOdd.Add(v);
			}

			
			int countOdd=0,countEven=0;

			foreach(Vertex v in vOdd)
			{
				countOdd+=g.degree(v);
			}
			foreach(Vertex v in vEven)
			{
				countOdd+=g.degree(v);
			}
			
			///Theorem1==>
			///
			if(countOdd+countEven==2*g.vertexes.Length && 2*g.vertexes.Length%2==0 && countEven%2==0){
				return countOdd%2==0;
			}
			else
				return false;
	

		}
		
	}
	
}//namespace
