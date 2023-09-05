#include <iostream.>
using namespace std;
int main()
{
	int num;
	cout<<" enter the day number:";
	cin>>num;
	switch (num)
	{
		case 0: cout<<"monday";
		break;
		case 1: cout<<"tuesday";
		break;
		case 2: cout<<"wednesday";
		break;
		case 3: cout<<"thuresday";
		break;
		case 4: cout<<"friday";
		break;
		case 5: cout<<"saturday";
		break;
		case 6: cout<<"sunday";
	}
	return 0;
}
