#include<iostream>
using namespace std;
class shape
{
	public:
		virtual void draw() 
		{
			cout<<"draw method of shape class"<<endl;
		}
};
class rectangle:public shape
{
	public:
		void draw()
		{
			cout<<"draw method of rectangle class"<<endl;
		}
};
int main()
{

shape *s;
shape s1;
rectangle r1;
s= &s1;
s->draw();
s= &r1;
s->draw();
return 0;
}
