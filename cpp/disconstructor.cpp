#include<iostream>
using namespace std;
class employee
{
public:
employee()
{
	cout<<"constructor called"<<endl;
}
~employee()
{
	cout<<"disconstructor called"<<endl;
}
};
int main()
{
	employee e1;
	employee e2;
	return 0;
}
