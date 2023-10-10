# Maxs-Marvellous-Mess
Spaghetti code for you to try and refactor

The class 'CastleWall' in Program.cs contains logic to allow / deny a list of visitors access to the castle, it's fully functional but needs refactoring.

The code in CastleWall must allow/deny access to visitors based on the following criteria:
1) Visitors may not have any repeating letters in their names
2) Visitors may not be taller than 6.5ft (lack of headroom)
3) Visitors must have a valid reason for visiting the castle. Valid reasons are (case sensitive): "Work", "Holiday" & "Returning Home"

The king has several knights who frequent the castle and may break rule 2 or 3 above. Knights can be identified as having all of the following characteristics:
- Their name begins with "Sir "
- Their reason for entry ends with " in service of his majesty the king"

Finally, the King will allow anyone who breaks every rule, 1 - 3, entry to the castle.
