   M S B A M L   `   `   `  ����D  @MyManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:MyManager.ViewsMyManager.Views  5           MyManager.Views.FilesPanel   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:MyManager.Views     5      .��5	      � ���	#FFD6C9C9.+�5
   
   �� $
��Left=�6   $	��378��62   $	��Top=�6?   $	��500��6W   $��0,24,0,0q�6c   .��5      �� -   5        $��
filesStack��5      5      �� 5   
   -   5          ��Name$  createNewDirectoryButton��5      $��Nowy folder��63   $
��Left=�6I   $	��Top=�6d   $��75��6|   $��
10,432,0,0q�6�   6�   �� 5   
   -   5        $  searchButton��5      $��Szukaj��6'   $
��Left=�68   $	��Top=�6S   $��75��6k   $��
10,407,0,0q�6v   �� 5   
   -   5         ��Name$ 
searchName��5      $
��Left=�6&   $��20��6A    �� TextWrapping$
 Wrap=�6M   $	��Top=�6b   $	��120��6z   $��
90,407,0,0q�6�    J� RenderTransformOrigin$ 0.472,-0.817&�6�   6�   �� 5   
   -   5        $ newDirectoryName��5      $
��Left=�6,   $��20��6G   $
 Wrap=�6S   $	��Top=�6h   $	��120��6�   $��
90,432,0,0q�6�   �� 5   
   -   5        $  
sortButton��5      $��Sortuj��6%   $
��Left=�66   $	��Top=�6Q   $��75��6i   $��215,407,0,0q�6t   6�   �� 5   
   -   5         ��Name$ dateSortCheckBox��5      $��Po dacie��6-   $
��Left=�6@   $	��Top=�6[   $��295,410,0,0q�6s   $ 1.724,0.267&�6�   �� 5   
   -   5        $ nameSortCheckBox��5      $��	Po nazwie��6-   $
��Left=�6A   $	��Top=�6\   $��364,410,0,0q�6t   �� 5   
   -	   5        $  backDirectory��5      $��Cofinj folder��6(   $
��Left=�6@   $	��Top=�6[   $��75��6s   $��215,432,0,0q�6~   6�   �� 5   
   -
   5         ��Name$ currentPathLabel��5      $��Label��6*   $
��Left=�6:   $	��Top=�6U   $��24��6m   $	��462��6y   ���	#FFFFFDFD6�   �� 5   
   -   5         ��Name$ imageReader��5      $y�Hidden=�6%   $
��Left=�69   $	��383��6T   $	��Top=�6a   $	��500��6y   $��0,24,0,0q�6�   �� 5   
   -   5        $  closeReader��5      $��Zamknij przeglądarkę��6&   $
��Left=�6E   $	��Top=�6`   $	��142��6x   $��295,432,0,0q�6�   6�   �� 5   
   -   5        $ 
textReader��5       �� 
IsReadOnly . $y�Hidden=�69   $
��Left=�6M   $	��378��6h   $
 Wrap=�6u   $�� ��6�   $	��Top=�6�   $	��500��6�   $��0,24,0,0q�6�   �� 5   
   -   5         ��Name$ 
drivesList��5      $
��Left=�6'   $	��Top=�6B   $��38��6Z   $��	462,0,0,0q�6e   $��24��6x   6�   5      5      