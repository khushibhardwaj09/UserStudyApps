using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TfLiteManager
{
    public static ITfLiteManager Instance;

    public static string[,] LABELS = { //{ "dad", "elephant", "red", "where", "yellow" },
                                       //{ "dad", "elephant", "owl", "red", "where" },

                                       
                                       { "dance", "food", "old", "yellow", "zebra"},

                                       /*
                                       { "elephant", "fireman", "owl", "red", "where"},
                                       { "chocolate", "for", "french fries", "sleep", "stuck" },
                                       { "alligator", "animal", "before", "boy", "cute" }};
                                        */ 
                                        {"fine", "flower", "frog", "giraffe", "wait"},
                                        {"find", "hungry", "make", "tiger", "tree"},
                                        {"drink", "lion", "mom", "napkin", "please"}};
                                        
                                       //{ "dad", "flower", "frog", "giraffe", "wait" },
                                       //{ "hungry", "make", "pretty", "tiger", "tree" },
                                       //{ "find", "hungry", "make", "tiger", "tree" },
                                       //{ "have to", "lion", "please", "sad", "scissors" },
                                       //{ "have to", "lion", "napkin", "please", "scissors" },
                                       //{ "dance", "food", "hot", "where", "yellow" }};
}
