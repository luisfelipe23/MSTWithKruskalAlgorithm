# MSTWithKruskalAlgorithm

## About this program

Our program is basically divided into two parts:
* Initially, it reads a file named "**EdgesFile.txt**", where there is a description of a graph:
  * The **first line** indicates the **number of vertices**;
  * The **second** one indicates the **number of edges**;
  * All the lines above, except the last one, indicates, respectively, the **origin vertex**, the **destination vertex** and the **edge weight**. Each one is separeted by a space;
  * The last line is a "**\n**" char.
* After reading the file, it generates a new graph with an **Adjacent Matrix** representation;
* After that, using the generated graph, a new **Minimum Spanning Tree (MST)** is generated using the **Kruskal Algorithm**.
<br>

* The **second part** consists of a set of performance testes;
  *  Basically, there are generated a previously defined quantity of **random graphs**. These graphs also have their **number of vertices** and **number of edges** previously defined. The **weight** is a randommically value generated;
  *  After generating the graphs, their **MSTs** are also generated;
  *  The application ends showing the **elapsed time** of each realized test.

