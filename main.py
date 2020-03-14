"""
CLI for benchmarking the different implementations.
"""
from datetime import datetime
import python_implementation
from sys import argv, exit

IMPLEMENTATIONS = {
    "python": python_implementation.has_collided
}


def build_projectile(x_pos):
    return (x_pos - 1, 99), (x_pos + 1, 99), (x_pos - 1, 101), (x_pos + 1, 101)


def run_benchmark(iterations, test_implementation):
    """
    Runs a speed benchmark on test_implementation.
    :param iterations: The number of times to repeat each test
    :param test_implementation: The callable for the the implementation to test
    :return: Seconds elapsed
    """
    target = ((195, 95), (205, 95), (205, 105), (195, 105))

    start = datetime.now()

    for count in range(0, iterations):
        x_pos = 100

        while not test_implementation(target, build_projectile(x_pos)):
            x_pos += 1

    return (datetime.now() - start).total_seconds()


def parse_args():
    assert len(argv) == 3
    return int(argv[1]), IMPLEMENTATIONS[argv[2]]


def main():
    try:
        iterations, implementation = parse_args()
    except:
        print("Usage: python main.py [iterations] [implementation]")
        print("Valid implementations:", ", ".join(IMPLEMENTATIONS.keys()))
        exit(1)

    print("Running benchmark...")

    result = run_benchmark(iterations, implementation)

    print("Completed in {:.4f} seconds".format(result))


if __name__ == "__main__":
    main()
