# Benchmarking

This is simply an area where I'm tinkering with side-by-side comparisons between
programming languages, frameworks, libraries/tools, and programming techniques.

## Usage

Using the `time` util in Linux to clock the attempts, count to 100,000,000 in Node:


```
# time node count.js 

real    0m0.151s
user    0m0.144s
sys     0m0.007s
```

vs PHP 7:

```
# time php count.php

real	0m1.721s
user	0m1.709s
sys		0m0.010s
```

vs Python3:

```
# time python3 count.py

real    0m10.101s
user    0m10.087s
sys     0m0.004s
```

I originally had them counting to 1 billion, but my computer's fan kicked on and
I was afraid the machine was going to explode when I ran the script in Python.

But the results when counting to 1 billion:

```
# time node count.js

real    0m0.951s
user    0m0.945s
sys     0m0.005s

# time php count.php

real	0m16.677s
user	0m16.661s
sys	    0m0.011s

# time python3 count.py

real    1m48.121s
user    1m48.006s
sys     0m0.006s
```
