### Brainstorming

Reindeer
 - Needs Magical Energies
 - Eat special type of StarFruit
Objective
 - needs to retrieve a minimum of _fifty stars_ by December 25th.
 - you decide to grab any fruit you see along the way
 - Solve puzzle to get magical star fruit

Scenario
- journey on boat
- Calorie (_Calories_) they carry of each elf  -> input file
- Each elf writes down calorie intake in input file
- Each Elf separates their own inventory from the previous Elf's inventory (if any) by a blank line

Puzzle:
In case the Elves get hungry and need extra snacks, they need to know which Elf to ask: they'd like to know how many Calories are being carried by the Elf carrying the _most_ Calories. In the example above, this is _`24000`_ (carried by the fourth Elf).

Find the Elf carrying the most Calories. _How many total Calories is that Elf carrying?_


Open Input file
loop till end of file
	Read  line
	If not empty 
		add value(integer) to current index in array
		read next line
	else
	change to next array index

output the index with highest value