# Python Interoperability Benchmarking
Tests the performance impact of using native libraries to replace CPU-intensive parts of Python programs. (A follow-up 
to my previous project on [benchmarking programming languages](https://gist.github.com/JoelEager/421b180131560ca862f4cd97f13b4495).)

For the F# implementation I used [pythonnet](https://github.com/pythonnet/pythonnet) which provides an interoperability 
layer bridging .NET and the CPython interpreter.

## Setup
The Python code requires CPython 3.5 or newer and the PyPI packages in `requirements.txt`.

The F# code requires [.NET Framework 4.8](https://dotnet.microsoft.com/download/dotnet-framework/net48).

Once both are installed, build the F# library. After that you should be good to run any of the scripts listed below.

## Usage
### Run the benchmark
```bash
python3 main.py [iterations] [implementation]
```

(Where `implementation` is `python` or `fsharp`.)

### Run the implementation tests
```bash
python3 test.py
```

### Run the .NET interop tests
```bash
python3 fsharp_implementation.py
```

## Results
These results where collected on a desktop with an AMD Ryzen 5 2600X using 50,000 iterations.

**Python:** 72.1551 seconds

**F#:** 61.6405 seconds
