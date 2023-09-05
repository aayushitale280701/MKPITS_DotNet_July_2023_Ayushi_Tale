#include<iostream>
using namespace std;
class media_player
{
	public:
		virtual void play()=0;
		virtual void pause()=0;
		virtual void stop()=0;
};
class audio_player:public media_player
{
	public:
		void play()
		{
			cout<<"video player is play"<<endl;
		}
		void pause()
		{
			cout<<"video player is pause"<<endl;
		}
		void stop()
		{
			cout<<"video player is stop"<<endl;
		}
};
class video_player:public media_player
{
	public:
		void play()
		{
			cout<<"video player is play"<<endl;
		}
		void pause()
		{
			cout<<"video player is pause"<<endl;
		}
		void stop()
		{
			cout<<"video player is stop"<<endl;
		}
};
int main()
{
	media_player *m;
	audio_player a;
	video_player v;
	m=&a;
	m->play();
	m->pause();
	m->stop();
	cout<<"---------"<<endl;
	m=&v;
	m->play();
	m->pause();
	m->stop();
	return 0;
	
}
