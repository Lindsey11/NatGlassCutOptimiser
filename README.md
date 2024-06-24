#Nat Glass Technical Assessment

Question 1: Optimization Algorithms for Glass Cutting
To efficiently cut glass panels with minimal waste, we need to consider optimization algorithms that can handle the arrangement of panels on a stock sheet. Here are some approaches:

Algorithms
1. Greedy Algorithm:
Pros:
Simple to implement and runs quickly.
Cons:
Often does not provide the optimal solution as it makes local optimal choices without considering the global optimum.
Assumptions:
Assumes that the next best piece to cut is the largest piece that fits the remaining space.
2. Dynamic Programming:
Pros:
Can provide an optimal solution by considering all possible ways to cut the glass.
Cons:
Computationally expensive and may require significant memory for large input sizes.
Assumptions:
Assumes we can break the problem into smaller subproblems, solve them, and build the solution from these sub-solutions.
Practical Example of Each Algorithm
Greedy Algorithm:
By design, the algorithm would start by choosing the biggest stock sheet in the list. In practice, this is fine but it would completely ignore critical business factors.

Issues with Greedy Algorithm:

Cost Factor:
The implementation would need to be adjusted to make sure the stock sheet chosen is the cheapest first. This would allow the optimizer to use off-cuts and start with the cheapest options. This brings its own complexity that I won't dig into now for the context of this assessment.
Optimized Panel Layout:
The greedy algorithm creates a problem where it would choose the biggest panel to start the layout with. This won't always create a layout that is the most efficient use of space and won't consider the most efficient layouts for the best cutting paths.
In both cases, the algorithm would need to be abstracted for all the business cases and fringe cases. The codebase could very quickly become hard to maintain and grow.

Dynamic Programming:
I feel this would be the best approach for building a solution that takes into account the required process from beginning to end. The concept of dynamic programming allows the programmer to create the "correctness" of a brute force approach but include concepts from the greedy algorithms at the core selection phase when the application is run.

Process with Dynamic Programming:
The process of selecting the stock sheets and the panels can be broken into smaller services that can work independently but will depend on the output of each service to move to the next step.

Example:

Selecting the Stock Sheets:

Fetch a list of the stock sheets from an inventory database.
Sort this list using business logic as a guide, e.g., sort the list to put the cheapest stock sheets at the top of the list. This will put cost at the forefront of the program every time.
Additionally, the selection process can take into account the total surface area of the panels that need to be cut. Then find the cheapest stock sheet that covers the total surface area required.
Laying Out the Panels:

The dynamic approach would allow the developer to effectively play "Tetris" in the panel selection process.
The code can be written to calculate the maximum surface area of each panel by rotating the panel vertically or horizontally. This will allow for maximum coverage of the stock sheet for as many panels as possible.




Question 2:

![image](https://github.com/Lindsey11/NatGlassCutOptimiser/assets/32640512/5dd90042-8c10-4e2d-93c9-ea37d038924c)


Question 3:

See the windows form application code in the repo this readme belongs to.




Question 4:







