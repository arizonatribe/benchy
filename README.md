# Benchmarking

This is simply an area where I'm tinkering with side-by-side comparisons between
programming languages, frameworks, libraries/tools, and programming techniques.

## Version being tested for each language

* Golang - 1.8.3
* PHP - 7.1.7
* Python - 3.6.3
* Node - 9.7.1
* Ruby - 2.3.3

## Results

Using the `time` util in Linux to clock the attempts, looping 100,000,000 times:

```
# time go run count.go

real    0m0.206s
user    0m0.155s
sys     0m0.070s

# time php count.php

real	0m1.721s
user	0m1.709s
sys		0m0.010s

# time python3 count.py

real    0m10.101s
user    0m10.087s
sys     0m0.004s

# time node count.js 

real    0m0.151s
user    0m0.144s
sys     0m0.007s

# time ruby count.rb

real    0m4.516s
user    0m4.495s
sys     0m0.015s
```

I originally had them looping 1 billion times, but my computer's fan kicked on and I feared my machine was going to explode when I ran the script in Python.

But the results when looping 1 billion times:

```
# time go run count.go

real    0m0.429s
user    0m0.377s
sys     0m0.068s

# time php count.php

real	0m16.677s
user	0m16.661s
sys	    0m0.011s

# time python3 count.py

real    1m48.121s
user    1m48.006s
sys     0m0.006s

# time node count.js

real    0m0.951s
user    0m0.945s
sys     0m0.005s

# time ruby count.rb

real    0m44.001s
user    0m43.899s
sys     0m0.065s
```

### Summary 

Golang was outperformed by Node in the first test (looping 100,000,000 times) but Golang passed Node in the second test (looping 1 billion times).

Also, Python was consistently slowest, but its a huge performance loss between both tests (10 seconds vs 1 min 48 seconds)
