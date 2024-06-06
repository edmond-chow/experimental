sudo apt-get install ncurses-dev
sudo apt install net-tools
sudo apt install xterm
sudo apt install xtitle
sudo apt install build-essential dkms linux-headers-$(uname -r)
sudo apt install openssh-server
sudo apt install libx11-dev
sudo apt-get install libsfml-dev
Vbox_Gas_6.1.36/autorun.sh
sudo cp lib.conf /etc/ld.so.conf.d
sudo gedit ld.so.conf
ldconfig
