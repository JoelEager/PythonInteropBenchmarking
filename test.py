"""
Simple script for validating the implementations.
"""
import fsharp_implementation
import python_implementation
from main import build_projectile


def validate_implementations():
    target = ((195, 95), (205, 95), (205, 105), (195, 105))
    x_pos = 100

    while x_pos < 300:
        projectile = build_projectile(x_pos)

        rp = python_implementation.has_collided(target, projectile)
        rf = fsharp_implementation.has_collided(target, projectile)

        print(x_pos, rp, rf)
        assert rp == rf

        x_pos += 1


if __name__ == "__main__":
    validate_implementations()
    print("Test passed")
