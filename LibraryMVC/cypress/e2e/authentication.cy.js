describe('LibraryMVC', () => {

    //login attempt without correct email format
    it('login', () => {
        cy.visit('https://localhost:7258/');
        cy.get('body > header > nav > div > div > ul:nth-child(2) > li:nth-child(2) > a').click();


        cy.get('#Input_Email').type('test');
        cy.get('#Input_Password').type('test');
        
        
    });
});