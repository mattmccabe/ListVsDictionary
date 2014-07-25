ListVsDictionary
================

Comparing C# List and Dictionary performance for doing lookups

Results
=======

Gains are pretty small in these tests.

Testing 1 Items with 1 lookups
   List running:
	Creation:00:00:00.0002700	Lookup: 00:00:00.0000012
   Dictionary running:
	Creation:00:00:00.0062114	Lookup: 00:00:00.0001240

Testing 10 Items with 1 lookups
   List running:
	Creation:00:00:00.0000023	Lookup: 00:00:00.0000004
   Dictionary running:
	Creation:00:00:00.0000048	Lookup: 00:00:00.0000003

Testing 100 Items with 1 lookups
   List running:
	Creation:00:00:00.0000056	Lookup: 00:00:00.0000044
   Dictionary running:
	Creation:00:00:00.0000060	Lookup: 00:00:00.0000013

Testing 1000 Items with 1 lookups
   List running:
	Creation:00:00:00.0000238	Lookup: 00:00:00.0001690
   Dictionary running:
	Creation:00:00:00.0008438	Lookup: 00:00:00.0000139

Testing 10000 Items with 1 lookups
   List running:
	Creation:00:00:00.0000469	Lookup: 00:00:00.0033933
   Dictionary running:
	Creation:00:00:00.0000609	Lookup: 00:00:00.0002635

Testing 1 Items with 5 lookups
   List running:
	Creation:00:00:00.0000009	Lookup: 00:00:00.0000001
   Dictionary running:
	Creation:00:00:00.0000012	Lookup: 00:00:00.0000001

Testing 10 Items with 5 lookups
   List running:
	Creation:00:00:00.0000044	Lookup: 00:00:00.0000005
   Dictionary running:
	Creation:00:00:00.0000045	Lookup: 00:00:00.0002804

Testing 100 Items with 5 lookups
   List running:
	Creation:00:00:00.0000059	Lookup: 00:00:00.0000060
   Dictionary running:
	Creation:00:00:00.0000060	Lookup: 00:00:00.0000048

Testing 1000 Items with 5 lookups
   List running:
	Creation:00:00:00.0000167	Lookup: 00:00:00.0001832
   Dictionary running:
	Creation:00:00:00.0000204	Lookup: 00:00:00.0000467

Testing 10000 Items with 5 lookups
   List running:
	Creation:00:00:00.0000331	Lookup: 00:00:00.0034867
   Dictionary running:
	Creation:00:00:00.0000416	Lookup: 00:00:00.0005260

Testing 1 Items with 10 lookups
   List running:
	Creation:00:00:00.0000010	Lookup: 00:00:00.0000001
   Dictionary running:
	Creation:00:00:00.0000008	Lookup: 00:00:00.0000001

Testing 10 Items with 10 lookups
   List running:
	Creation:00:00:00.0000022	Lookup: 00:00:00.0000003
   Dictionary running:
	Creation:00:00:00.0000023	Lookup: 00:00:00.0000004

Testing 100 Items with 10 lookups
   List running:
	Creation:00:00:00.0000036	Lookup: 00:00:00.0000060
   Dictionary running:
	Creation:00:00:00.0000037	Lookup: 00:00:00.0000048

Testing 1000 Items with 10 lookups
   List running:
	Creation:00:00:00.0000164	Lookup: 00:00:00.0001801
   Dictionary running:
	Creation:00:00:00.0000184	Lookup: 00:00:00.0000488

Testing 10000 Items with 10 lookups
   List running:
	Creation:00:00:00.0000407	Lookup: 00:00:00.0035439
   Dictionary running:
	Creation:00:00:00.0000438	Lookup: 00:00:00.0006060

Testing 1 Items with 50 lookups
   List running:
	Creation:00:00:00.0000011	Lookup: 00:00:00.0000001
   Dictionary running:
	Creation:00:00:00.0000011	Lookup: 00:00:00.0000001

Testing 10 Items with 50 lookups
   List running:
	Creation:00:00:00.0000023	Lookup: 00:00:00.0000004
   Dictionary running:
	Creation:00:00:00.0000026	Lookup: 00:00:00.0000006

Testing 100 Items with 50 lookups
   List running:
	Creation:00:00:00.0000055	Lookup: 00:00:00.0000063
   Dictionary running:
	Creation:00:00:00.0000060	Lookup: 00:00:00.0000040

Testing 1000 Items with 50 lookups
   List running:
	Creation:00:00:00.0000168	Lookup: 00:00:00.0001873
   Dictionary running:
	Creation:00:00:00.0000202	Lookup: 00:00:00.0000500

Testing 10000 Items with 50 lookups
   List running:
	Creation:00:00:00.0000340	Lookup: 00:00:00.0054541
   Dictionary running:
	Creation:00:00:00.0000735	Lookup: 00:00:00.0008618

Testing 1 Items with 100 lookups
   List running:
	Creation:00:00:00.0000015	Lookup: 00:00:00.0000001
   Dictionary running:
	Creation:00:00:00.0000013	Lookup: 00:00:00.0000001

Testing 10 Items with 100 lookups
   List running:
	Creation:00:00:00.0000036	Lookup: 00:00:00.0000005
   Dictionary running:
	Creation:00:00:00.0000042	Lookup: 00:00:00.0000005

Testing 100 Items with 100 lookups
   List running:
	Creation:00:00:00.0000064	Lookup: 00:00:00.0000067
   Dictionary running:
	Creation:00:00:00.0000061	Lookup: 00:00:00.0000035

Testing 1000 Items with 100 lookups
   List running:
	Creation:00:00:00.0000278	Lookup: 00:00:00.0002853
   Dictionary running:
	Creation:00:00:00.0000314	Lookup: 00:00:00.0000573

Testing 10000 Items with 100 lookups
   List running:
	Creation:00:00:00.0000331	Lookup: 00:00:00.0033754
   Dictionary running:
	Creation:00:00:00.0000403	Lookup: 00:00:00.0005232
