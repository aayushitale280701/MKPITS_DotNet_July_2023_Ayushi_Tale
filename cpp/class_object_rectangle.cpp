#include<iostream>
using namespace std;
class rectangle
{
	public:
		int length;
		int width;
	int calculatearea()
	{
		int a=length*width;
		return a;
	}
	int calculatepara()
	{
		int para=2*length+width;
		return para;
	}
};
int main()
{
	float result;
	rectangle r1;
	cout<<"enter length of rectangle:";
	cin>>r1.length;
	cout<<"Enter width of rectangle:";
	cin>>r1.width;
	result=r1.calculatearea();
	cout<<"area of a rectangle="<<result<<endl;
	result=r1.calculatepara();
	cout<<"parameter of rectangle="<<result;
}
