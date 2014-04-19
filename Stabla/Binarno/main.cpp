#include <iostream>
#include "binary_tree.h"
#include "extra_functions.h"

using namespace std;

int main()
{
	binaryTree oak;

	int numbers[7] = {3, 6, 7, 2, 8, 1, 5};

	oak = create_tree(numbers, 7);

	int depth = 0;

	tree_depth(oak.root(), 1, depth);

	cout << "Depth: " << depth << endl;

	int leaves = 0;

	tree_leaves(oak.root(), leaves);

	cout << "Leaves: " << leaves << endl;

	int smallest = numbers[0];

	tree_smallest(oak.root(), smallest);

	cout << "Smallest: " << smallest << endl;

	int sum = 0;

	tree_odd_sum(oak.root(), sum);

	cout << "Sum of odd members: " << sum << endl;

	cout << endl;

	return 0;
}