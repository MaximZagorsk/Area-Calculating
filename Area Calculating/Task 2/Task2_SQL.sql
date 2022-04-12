SELECT
		p.product_name,
    	c.category_name
FROM  
	db.correspondence_products_and_categories cpac
LEFT OUTER JOIN 
	db.products p ON  p.id = cpac.product_id
LEFT OUTER JOIN 
	db.categories c ON cpac.categories_id = c.id;
