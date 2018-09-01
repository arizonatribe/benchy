# Benchmarking

This is simply an area where I'm tinkering with side-by-side comparisons between
programming languages, frameworks, libraries/tools, and programming techniques.

## Version being tested for each language

* Dotnet - 2.1.105
* Golang - 1.9.7
* Java - 10.0.2
* PHP - 7.1.21
* Python - 3.6.6
* Node - 9.7.1
* Ruby - 2.4.4

## Results

Using the `time` util in Linux to clock the attempts, looping 100,000,000 times:

```
# time go run count.go

real	0m0.164s
user	0m0.159s
sys	  0m0.038s

# time php count.php

real	0m1.407s
user	0m1.399s
sys	  0m0.007s

# time python3 count.py

real	0m9.830s
user	0m9.812s
sys	  0m0.008s

# time node count.js 

real	0m0.152s
user	0m0.141s
sys	  0m0.011s

# time ruby count.rb

real	0m4.332s
user	0m4.321s
sys	  0m0.007s

# time java Count

real	0m0.113s
user	0m0.128s
sys	  0m0.018s

# time dotnet run

real	0m1.930s
user	0m1.867s
sys	  0m0.265s
```

I originally had them looping 1 billion times, but my computer's fan kicked on and I feared my machine was going to explode when I ran the script in Python.

But the results when looping 1 billion times:

```
# time go run count.go

real	0m0.432s
user	0m0.427s
sys	  0m0.039s

# time php count.php

real	0m13.916s
user	0m13.893s
sys	  0m0.008s

# time python3 count.py

real    1m48.121s
user    1m48.006s
sys     0m0.006s

# time node count.js

real	0m0.944s
user	0m0.939s
sys	  0m0.004s

# time ruby count.rb

real	0m43.883s
user	0m43.767s
sys	  0m0.025s

# time java count

real	0m0.399s
user	0m0.412s
sys	  0m0.021s

# time dotnet run

real	0m4.136s
user	0m4.078s
sys	  0m0.261s
```

### Summary 

Golang was outperformed by Node in the first test (looping 100,000,000 times) but Golang passed Node in the second test (looping 1 billion times). Golang and Java performed nearly identical in the larger test, with Java having a miniscule edge over Golang. Node outperformed them both in the first test.

Also, Python was consistently slowest, but its a huge performance loss between both tests (10 seconds vs 1 min 48 seconds)
