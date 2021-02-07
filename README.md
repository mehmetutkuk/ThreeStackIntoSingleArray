# Three Stack Into a Single Array
Storing three stack into an array

The situation is the expectation of storing three stacks inside a single array.

Stack class has a constructor and takes two parameters. The first parameter is to decide stack count. The second one is to decide array length and then all spaces initialize as free.

When Overflow happens The property named "Full" returns -1 as value.

"Push" method takes two parameters one of them takes stack number, another is a value. when method called firstly spot the first free slot and update the next stack number coming as a parameter then put the item to the array.

"Pop"  method takes a parameter for stack number.
There is another property named "isEmpty" checks if stack underflow. After this finds the index of the stock number then change it as free.