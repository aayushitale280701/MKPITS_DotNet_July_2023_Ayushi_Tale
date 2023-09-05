#include<iostream>
using namespace std;
class game
{
	public:
		virtual void start()=0;
		virtual void play()=0;
		virtual void end()=0;
};
class tic_tac_too:public game
{
	public:
		void start()
		{
			cout<<"game is start"<<endl;
		}
		void play()
		{
			cout<<"game is play"<<endl;
		}
		void end()
		{
			cout<<"game is end"<<endl;
		}
};
class chees:public game
{
	public:
		void start()
		{
			cout<<"game is start"<<endl;
		}
		void play()
		{
			cout<<"game is play"<<endl;
		}
		void end()
		{
			cout<<"game is end"<<endl;
		}
};
int main()
{
	game *g;
	tic_tac_too t;
	chees c;
	g=&t;
	g->start();
	g->play();
	g->end();
	cout<<"-----------"<<endl;
	g=&c;
	g->start();
	g->play();
	g->end();
	return 0;
}
