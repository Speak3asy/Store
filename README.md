# VI&KO Store

Project is a thing of my study. I have a task to create a market system. One GUI as Master - with all warehouse overview, purchase history.. and other GUI is like a shop terminal, where you input groceries and get total sum etc.

## Prerequisites

Program is written in CSharp with Visual Studio 2015. Database is MSSQL 2012 Express. Database schema is in database.sql file.

## Contributing

1. Fork it!
2. Create your feature branch: `git checkout -b my-new-feature`
3. Commit your changes: `git commit -am 'Add some feature'`
4. Push to the branch: `git push origin my-new-feature`
5. Submit a pull request :D

p.s. Projektas.pdf is a task, what I have to do. Feel free to read and contribute if you want :)

## History

v1.00 - Few classes and interfaces. Few functions to pull data from database.

v1.01 - Added timer to update ListView. Added controls and input validation for adding produtct to database. Adding to database isn't implemented yet.

v1.02 - A mass update!
	
	* Add product is working. Input validation implemented.
	* Edit product is working. Input validation implemented.
	* Added Legend groupbox to explain colors.
	* Clicking warehouse item auto-fills Edit form.
	* Working checkout history.
	* Clicking history item auto-fills basket items and shows total sum.

## TODO

For Master program (80/100 completed):
	
	* Tweak Warehouse and Checkout History listview updating.
	* Implement gratis, bonus system. etc. Buy 2 for 1 price.

For Terminal program (0/100 completed):

	* Will update this later.

## Credits

Mindsoft (c)

## License

The MIT License (MIT)

Copyright (c) 2016, Arturas Radzevicius

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.