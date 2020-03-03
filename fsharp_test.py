import sys
from os import path

import clr

project_dir = path.dirname(path.abspath(__file__))
library_dir = path.join(project_dir, "FSharpImplementation", "bin", "Debug")
sys.path.append(library_dir)

clr.AddReference("FSharpImplementation")

from FSharpImplementationNamespace import SeparatingAxisTheorem

print(SeparatingAxisTheorem.mathTest(9, 2))
