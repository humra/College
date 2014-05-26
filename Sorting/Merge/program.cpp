#include<iostream>
#include<vector>

using namespace std;

void merge(int *poljea, int na, int *poljeb, int nb){
	vector<int> poljec;
	int ia = 0;
	int ib = 0;

	while(ia + ib != na + nb){
		if (ia == na){
			poljec.push_back(poljeb[ib]);
			ib++;
			continue;
		}

		if (ib == nb){
			poljec.push_back(poljea[ia]);
			ia++;
			continue;
		}

		if (poljea[ia] < poljeb[ib]){
			poljec.push_back(poljea[ia]);
			ia++;
		}
		else{
			poljec.push_back(poljeb[ib]);
			ib++;
		}
		}

	for (int i = 0; i < na + nb; i++){
		poljea[i] = poljec[i];
	}
	
}

void merge_sort(int *data, int from, int to){
	if (from == to) {
		return;
	}

	int mid = (from + to) / 2;
	merge_sort(data, from, mid);
	merge_sort(data, mid + 1, to);
	merge(data + from, mid - from + 1, data + mid + 1, to - mid);
}

int main(){
	int n = 10;
	vector<int> p;

	for(int i = 10; i > 0; i--) {
		p.push_back(i);
	}

	int *pp = &p[0];

	merge_sort(pp, 0, n-1);

	for (int i = 0; i < n; i++){
		cout << p[i] << " ";
	}

	cout << endl;
	return 0;
}