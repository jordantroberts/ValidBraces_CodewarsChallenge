﻿using System;
using System.Collections;
using System.Linq;

namespace ValidBracesCSharp {
    class Program {
        static void Main (string[] args) {

            while (true) {
                Console.WriteLine ("Please enter a string of braces");
                string input = Console.ReadLine ();
                if (input != "quit") {
                    Console.WriteLine (Brace.validBraces (input));

                } else {
                    break;
                }
            }

        }
    }
}

public class Brace {
    public static bool validBraces (String braces) {
        Stack checkedChars = new Stack ();

        for (int i = 0; i < braces.Length; i++) {
            if (braces[i] == '(' || braces[i] == '{' || braces[i] == '[') {
                checkedChars.Push (braces[i]);
            } else if (checkedChars.Count == 0) {
                return false;
            } else if ((braces[i].ToString () == ")" && checkedChars.Peek ().ToString () == "(") || (braces[i].ToString () == "}" && checkedChars.Peek ().ToString () == "{") || (braces[i].ToString () == "]" && checkedChars.Peek ().ToString () == "[")) {
                checkedChars.Pop ();
            } else {
                break;
            }
        }

        if (checkedChars.Count != 0) {
            return false;
        }

        return true;
    }
}