   M S B A M L   `   `   `  ����E  AGrpProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:GrpProject
GrpProject  5   	       GrpProject.AddUserWindow3   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:GrpProject     5   	     � Title$  AddUserWindow3��5   	   $	��450��6    $	��800��6-    � DataContext 5	         GrpProject.AddUserVM  5   
   .��5      � 
�������.+�5   
   �� 
�������$��20 10q�6'   .+�5      �� $	��800��6   $��5q�6%   .+�5      �� $!��Student Registration System��6   $��Center=�6>   $��25��6[   $��18(�5      $��1q�6"   $
��Bold"�6.   6B   �� 5      $2��,Faculty Of Engineering, University Of Ruhuna��6   $��Center=�6O   $��25��6l   $��18(�5      $��1q�6"   $
��Bold"�6.   6B   �� 5      $(��"Department Of Computer Engineering��6   $��Center=�6E   $��25��6b   $��18(�5      $��1q�6"   $
��Bold"�6.   6B   �� 5      $��Semester 05��6   $��Center=�6.   $��25��6K   $��15(�5      $��1q�6"   $
��Bold"�6.   6B   5      �� 5!       �� Orientation$ 
Horizontal=�6   $��5 10 5 5q�62   .+�5"      �� $	��400��6   .+�5#      �� $ 
Horizontal=�6!   $��10q�6:   .+�5$      �� $��First Name     :��6    $��15(�6;   $	��105��6I   6W   �� 5%      $	��295��6a   ��6"   �� *	Fristname+ �� UpdateSourceTrigger$ PropertyChanged=�6o   5&      �� 5'      $ 
Horizontal=�6!   $��10q�6:   .+�5(      �� $��Last Name     :��6    $��15(�6:   $	��105��6H   6V   �� 5)      $	��295��6`   ��6"   �� *
Lastname+$ PropertyChanged=�6n   5*      �� 5+      $ 
Horizontal=�6!   $��10q�6:   .+�5,      �� $��Date Of Birth :��6    $��15(�6:   $	��105��6H   6V   �� 5-      $	��295��6c   ��6"   �� *Dateofbirth+$ PropertyChanged=�6q   5.      51      �� 53      $	��400��6   .+�54      �� $ 
Horizontal=�6!   $��10q�6:   .+�55      �� $��Reg No      :��6    $��15(�68   $	��100��6F   6T   �� 56      $	��300��6]   ��6"   �� *Regno+$ PropertyChanged=�6k   57      �� 58      $ 
Horizontal=�6!   $��10q�6:   .+�59      �� $��Gender       :��6    $��15(�69   $	��100��6G   6U   �� 5:      $	��300��6[   ��6"   �� *Sex+$ PropertyChanged=�6i   5;      �� 5<      $ 
Horizontal=�6!   $��10q�6:   .+�5=      �� $��Batch          :��6    $��15(�6;   $	��100��6I   6W   �� 5>      $	��300��6]   ��6"   �� *Batch+$ PropertyChanged=�6k   5?      5A      5C      �� 5G      $ 
Horizontal=�6   $��5 50 5 5q�62   .+�5I      �� -   5        $��
backbutton��5J   X   $	��120��5I      $
��BACK��6%   $��18(�64   $��20 5 0 5q�6B      
mainbutten#��[  5J      $��30��6@   $��2q�6L   5K      �� 5M      -   5        $��
savebutton��5N   m   $	��200��5M      $
��SAVE��6%   $��18(�64   $��140 2.5 140 2.5 q�6B   
�������#��[  5N   0   $��35��6U   $��2q�6a   ��6   �� *SaveCommand+5O      �� 5Q      -   5        $��
exitbutton��5R   W   $	��120��5Q      $
��EXIT��6%   $��18(�64   $��0 5 20 5q�6B   #��[  5R      $��30��6?   $��2q�6K   5S      5V      5Y      5^      5_      