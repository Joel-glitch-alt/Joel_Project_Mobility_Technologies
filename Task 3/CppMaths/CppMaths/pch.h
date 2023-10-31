 // CppMath.h
#pragma once

extern "C" {
    __declspec(dllexport) int Multiple(int a, int b);
}

// CppMath.cpp
#include "CppMath.h"

int Multiple(int a, int b) {
    return a * b;
}