# Roman Numerals Converter

Convert numbers into Roman Numberals.

Compilers: Principles, Tecniques, and Tools - Exercise 2.1

## Context-Free Grammar

```
integer → digit | digit integer
digit → 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9
```

### Synax-Directed Translation

There should be no more then 3 of the same letter in a row.

```
digit.1 = I
digit.2 = II
digit.3 = III
digit.4 = IV
digit.5 = V
digit.6 = VI
digit.7 = VII
digit.8 = VIII
digit.9 = IX
digit.10 = X
digit.20 = XX
digit.30 = XXX
digit.40 = XL
digit.50 = L
digit.60 = LX
digit.70 = LXX
digit.80 = LXXX
digit.90 = XC
digit.100 = C
digit.200 = CC
digit.300 = CCC
digit.400 = CD
digit.500 = D
digit.600 = DC
digit.700 = DCC
digit.800 = DCCC
digit.900 = CM
digit.1000 = C
digit.2000 = CC
digit.3000 = CCC
```