"""
Provides an interface between the F# implementation of SAT and Python.

If this script is run directly it will make some test calls into F# and print the results.
"""
import sys
from os import path

import clr

project_dir = path.dirname(path.abspath(__file__))
library_dir = path.join(project_dir, "FSharpImplementation", "bin", "Debug")
sys.path.append(library_dir)

clr.AddReference("FSharpImplementation")

from FSharpImplementationNamespace import SeparatingAxisTheorem

has_collided = SeparatingAxisTheorem.hasCollied

if __name__ == "__main__":
    from System import Console
    Console.WriteLine("Hello from .net")
    print()

    print(SeparatingAxisTheorem.mathTest(9, 2))
    print()

    print(SeparatingAxisTheorem.argTest(((9, 2), (54, 4))))
    print()
