   M S B A M L   `   `   `  ����R  NHMTDPTeamLibraryProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:HMTDPTeamLibraryProject.ViewModels"HMTDPTeamLibraryProject.ViewModels  5      ,    &HMTDPTeamLibraryProject.SampleBookPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      G
viewModels0clr-namespace:HMTDPTeamLibraryProject.ViewModels     5        N� Title$  SampleBookPage��5	       � DataContext 5
      :   4HMTDPTeamLibraryProject.ViewModels.BookSampleStoreVM  5   
   .��5      � ��5   
   �� 5       �� Opacity$	 0.1Q�6"   .��5      �  � Color$ HotPink��6    � Offset$	 0.5Q�60   � 5      $ 	RosyBrown��6   $	 0.6Q�62   5       � RowDefinitions 5   
   �� 5      $��45 �6   �� 5      $��1* �6   �� 5      $��30 �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   $��	463,0,0,0q�6;   .+�5      �� -   5        $	��120��5      
�������$��1q�5      
���OO/�$��14(�5       $��Oblique$�5!      $��SemiBold"�5"      $��Center=�5#      $��Center=�5$      $��Open Articles��5%       � ToolTip$$ Open the current book articles��6-   $��5,5,5,5q�6V   ��5&      �� 5'      $
 0.01Q�6*   5(      5*      5,      �� 5-   
   -   5        $��mainOperateList��5-   A   
������ $��13(�6�   $��Normal"�6�   $��	0,0,337,0q�6�   $��2��6�   $��Verdana)�6      alternatingListViewStyle#���   6  ��6q   �� *Books+ �� View 5.      �� 5/      P�50      �� 51      	 �� Width$		 400��6)   $
��Book��65   
 �� DisplayMemberBinding
 6C   �� *Name+53      56      � 57   
   $��2��6    � ColumnDefinitions 58      �� 59      $	��100 �6#   �� 5:      $	��300 �6#   .+�5<      �� $ 
Horizontal=�6   $��1��62    6B   �� *SelectedStore+.+�5=      �� .��6   
Book name:6$   �� 5>      
������ ��6   �� *Name+60   5?      5@      5A      5B      