   M S B A M L   `   `   `  ����G  Cvarchar(128), Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:varchar_128_.viewvarchar_128_.view  5   	   '    !varchar_128_.view.AuthorBioWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:varchar_128_.view     5   	     � Title$  
Author bio��5   	   $	��380��6   $	��500��6)   .��5	      � $��20 10q�6    � RowDefinitions 5
   
   �� 5      $��1* �6   �� 5      $��3* �6   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   �� .+�5      �� -   5         ��Name$ 
listAuthor��5   +   $��Tahoma)�6    �� DisplayMemberPath$
 name��6?   6X   �� 5      -   5         ��Name$ tbDate��5   G   $��Tahoma)�6   $
��Left=�6,   6G   5      �� 5   
   -   5         ��Name$ spBio��5   0   $��1��6   $
��0 30q�6"   .+�5      �� $��Tahoma)�6   $	��Bin��6,   �� 5      -   5        $ tbBio��5   ,   $��Tahoma)�6   6,   5      �� 5   
   -   5        $ linkWiki��5   F   $��Tahoma)�6   $��Link more on Wikipedia��6(   $��2��6X   $
��Left=�6e   6�   �� 5   
   -   5        $��Tahoma)�5      
�������$��3��69   $��Close��6F   ���	#FF50673B6k   5      5      