ListVsDictionary
================

Comparing C# List and Dictionary performance for doing lookups

Results
=======

Gains are pretty small in these tests.

1 Items with 1 lookups
	List==>	Create:	00:00:00.0002113	Do lookup:	00:00:00.0000012
	Dict==>	Create:	00:00:00.0060925	Do lookup:	00:00:00.0001216

10 Items with 1 lookups
	List==>	Create:	00:00:00.0000021	Do lookup:	00:00:00.0000005
	Dict==>	Create:	00:00:00.0000048	Do lookup:	00:00:00.0000002

100 Items with 1 lookups
	List==>	Create:	00:00:00.0000059	Do lookup:	00:00:00.0000046
	Dict==>	Create:	00:00:00.0000060	Do lookup:	00:00:00.0000013

1000 Items with 1 lookups
	List==>	Create:	00:00:00.0000229	Do lookup:	00:00:00.0001919
	Dict==>	Create:	00:00:00.0010055	Do lookup:	00:00:00.0000251

10000 Items with 1 lookups
	List==>	Create:	00:00:00.0000460	Do lookup:	00:00:00.0035474
	Dict==>	Create:	00:00:00.0000544	Do lookup:	00:00:00.0001783

1 Items with 5 lookups
	List==>	Create:	00:00:00.0000009	Do lookup:	00:00:00.0000001
	Dict==>	Create:	00:00:00.0000011	Do lookup:	00:00:00.0000002

10 Items with 5 lookups
	List==>	Create:	00:00:00.0000020	Do lookup:	00:00:00.0000005
	Dict==>	Create:	00:00:00.0000043	Do lookup:	00:00:00.0003013

100 Items with 5 lookups
	List==>	Create:	00:00:00.0000053	Do lookup:	00:00:00.0000059
	Dict==>	Create:	00:00:00.0000057	Do lookup:	00:00:00.0000047

1000 Items with 5 lookups
	List==>	Create:	00:00:00.0000170	Do lookup:	00:00:00.0002786
	Dict==>	Create:	00:00:00.0000215	Do lookup:	00:00:00.0000623

10000 Items with 5 lookups
	List==>	Create:	00:00:00.0000324	Do lookup:	00:00:00.0035575
	Dict==>	Create:	00:00:00.0000469	Do lookup:	00:00:00.0006270

1 Items with 10 lookups
	List==>	Create:	00:00:00.0000011	Do lookup:	00:00:00.0000002
	Dict==>	Create:	00:00:00.0000013	Do lookup:	00:00:00.0000001

10 Items with 10 lookups
	List==>	Create:	00:00:00.0000019	Do lookup:	00:00:00.0000005
	Dict==>	Create:	00:00:00.0000024	Do lookup:	00:00:00.0000005

100 Items with 10 lookups
	List==>	Create:	00:00:00.0000038	Do lookup:	00:00:00.0000063
	Dict==>	Create:	00:00:00.0000038	Do lookup:	00:00:00.0000049

1000 Items with 10 lookups
	List==>	Create:	00:00:00.0000176	Do lookup:	00:00:00.0001812
	Dict==>	Create:	00:00:00.0000199	Do lookup:	00:00:00.0000480

10000 Items with 10 lookups
	List==>	Create:	00:00:00.0000371	Do lookup:	00:00:00.0034369
	Dict==>	Create:	00:00:00.0000443	Do lookup:	00:00:00.0005910

1 Items with 50 lookups
	List==>	Create:	00:00:00.0000011	Do lookup:	00:00:00.0000001
	Dict==>	Create:	00:00:00.0000012	Do lookup:	00:00:00.0000001

10 Items with 50 lookups
	List==>	Create:	00:00:00.0000018	Do lookup:	00:00:00.0000003
	Dict==>	Create:	00:00:00.0000024	Do lookup:	00:00:00.0000004

100 Items with 50 lookups
	List==>	Create:	00:00:00.0000038	Do lookup:	00:00:00.0000045
	Dict==>	Create:	00:00:00.0000038	Do lookup:	00:00:00.0000031

1000 Items with 50 lookups
	List==>	Create:	00:00:00.0000170	Do lookup:	00:00:00.0001828
	Dict==>	Create:	00:00:00.0000196	Do lookup:	00:00:00.0000498

10000 Items with 50 lookups
	List==>	Create:	00:00:00.0000356	Do lookup:	00:00:00.0034761
	Dict==>	Create:	00:00:00.0000407	Do lookup:	00:00:00.0005887

1 Items with 100 lookups
	List==>	Create:	00:00:00.0000008	Do lookup:	00:00:00.0000001
	Dict==>	Create:	00:00:00.0000012	Do lookup:	00:00:00.0000001

10 Items with 100 lookups
	List==>	Create:	00:00:00.0000019	Do lookup:	00:00:00.0000004
	Dict==>	Create:	00:00:00.0000024	Do lookup:	00:00:00.0000004

100 Items with 100 lookups
	List==>	Create:	00:00:00.0000037	Do lookup:	00:00:00.0000049
	Dict==>	Create:	00:00:00.0000039	Do lookup:	00:00:00.0000026

1000 Items with 100 lookups
	List==>	Create:	00:00:00.0000170	Do lookup:	00:00:00.0001744
	Dict==>	Create:	00:00:00.0000194	Do lookup:	00:00:00.0000398

10000 Items with 100 lookups
	List==>	Create:	00:00:00.0000338	Do lookup:	00:00:00.0033959
	Dict==>	Create:	00:00:00.0000416	Do lookup:	00:00:00.0005561
