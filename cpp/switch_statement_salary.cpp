# include <iostream>
using namespace std;
int main()
{
	char name[20];
	char designation;
	int salary;
	cout<<"ent emp name";
	cin>>name;
	cout <<"ent designation(m,c,p)";
	cin>>designation
	switch (designation)
	{
		case'm'
	    salary=20000;
		break;
		case'c'
		salary=10000;
		break;
		case'p'
		salary=30000;
		break;
	}
	cout<<"employe="<<name;
	cout<<"\n salary="<<salary;
}
