sudo ln -s '$HOME/projects/Complex/Complex Testing Console/bin/ARM/Release/libComplex.so' '/usr/lib/libComplex.so'
sudo rm '/usr/lib/libComplex.so'
echo "$HOME/projects/Complex/Complex Testing Console/bin/ARM/Release" > lib.conf
'./Complex Testing Console.out'