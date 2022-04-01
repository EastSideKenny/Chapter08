/*
 * 1.What is the maximum number of chars that can be stored in a string variable?
 * 
 * The maximum size of a string variable is 2 GB, or about one billion characters,
    because each character uses 2 bytes due to the internal use of Unicode (UTF-16)
    encoding for characters in a string.
 * 
 * 2. When and why should you use a SecureString type?
 * 
 * The string type leaves text data in the memory for too long, and it's too
    visible. The SecureString type encrypts its text and ensures that the memory is released
    immediately. For example, in WPF, the PasswordBox control stores its password as a
    SecureString variable, and when starting a new process, the Password parameter must
    be a SecureString variable
 * 
 * 3. When is it appropriate to use a StringBuilder class?
 * 
 * When concatenating more than about three string variables, you will use less
    memory and get improved performance using StringBuilder than using the string.
    Concat method or the + operator
 * 
 * 4. When should you use LinkedList<T> class?
 * 
 * Each item in a linked list has a reference to its previous and next siblings as
    well as the list itself. A linked list should be used when items need to be inserted and
    removed from positions in the list without moving the items in memory.
 * 
 * 5. When should you use a SortedDictionary<T> class rather  than a SortedList<T> class?
 * 
 * The SortedList<T> class uses less memory than SortedDictionary<T>;
    SortedDictionary<T> has faster insertion and removal operations for unsorted data.
    If the list is populated all at once from sorted data, SortedList<T> is faster than
    SortedDictionary<T>.
 * 
 * 6. What is the ISO culture code for welsh?
 * 
 * cy-GB
 * 
 * 7. What is the difference between localization , globalization and internationalization?
 * 
 * Localization : language only
 * globalization : language - region
 * internationalization : combination of the 2 above
 * 
 * 
 * 8. In a regular expression waht does $ mean?
 * end of input
 * 
 * 9. In a regular expression, how can you represent digits?
 * \d
 * 
 * 10. Why should you not use the official standard for email adresses to create a regular
 * expression to validate a users mail address?
 * 
 * even if it is a valid email address format we cannot validate that the address exists / belongs to the user that entered it.
 * 
 */