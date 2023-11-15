

What is an Array
===============================================================================================================
An Array is a collection of items. 
The items could be integers, strings, games, books—anything really. 
The items are stored in neighboring (contiguous) memory locations. 
Because they're stored together, checking through the entire collection of items is straightforward.


Real life Example of Array
===============================================================================================================

                DVD Box                                     DVD
                                                                
            ################                              #######     #######
           ##            ###                              #     #     #     #
          ##            ## #                              #     #     #     #
         ################  #                              #######     #######
         #              #  #
         #              #  #
         #              # # 
         #################
         
===============================================================================================================


Array Capacity
===============================================================================================================

Remembering that indexing starts at 0, 
we can only insert items at 
dvdCollection[0], dvdCollection[1], dvdCollection[2], dvdCollection[3], dvdCollection[4], and dvdCollection[5]. 

Trying to put an element anywhere else, 
such as
dvdCollection[-3], dvdCollection[6], or dvdCollection[100] 
will cause your code to crash with an `ArrayIndexOutOfBoundsException!`
