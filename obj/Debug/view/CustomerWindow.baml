   M S B A M L   `   `   `  ����G  Cvarchar(128), Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:varchar_128_.viewvarchar_128_.view  5   	   &     varchar_128_.view.CustomerWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:varchar_128_.view     5   	     � Title$  CustomerWindow��5   	   $	��450��6    $	��800��6-   .��5	      � $��0 0 0 20q�6    � ColumnDefinitions 5
   
   �� 5      $��1* �6   �� 5      $��4* �6   .+�5   
   �  � RowDefinitions 5      �� 5      $	��10* �6    �� 5      $��1* �6    .+�5      A� $��
10 40 10 0q�6    A� Rows$ 3��6.   $	��Top=�67   .+�5      �� .+�5      �� $��Customer ID��6    �� 5      -   5         ��Name$
 tbId��5      5      �� 5      $��	 0 10 0 0q�6   .+�5      �� $
��Name��6    �� 5      -   5        $ tbName��5      5      �� 5      -   5        $��Search��5      $��0 10 0 0q�6+   6=   5      �� 5      $��1��6   $��Center=�6&   $��Center=�6A    �� Orientation$ 
Horizontal=�6^   .+�5      �� -   5        $
��Edit��5      $
��20 0q�6(   $��0 0 5 0q�67   6H   �� 5       -   5        $	��Add��5       $
��20 0q�6'   $��5 0 0 0q�66   6G   5!      5"      &   System.Windows.Controls.DataGrid  5#   
   -   5          Name$ dgCustomers��5#   #   $��1��6      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 68      CanUserAddRows .  	   CanUserDeleteRows	 .  
   CanUserResizeColumns
 .     AutoGenerateColumns .     Columns 5$      0  *System.Windows.Controls.DataGridTextColumn  5%      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *id+  5&      $
 Name��6%    63   �� *name+  5'      $ Address��6%    66   �� *	address+  5(      $	 Zip��6%    62   �� *zip+  5)      $
 City��6%    63   �� *city+5+      5,      5-      