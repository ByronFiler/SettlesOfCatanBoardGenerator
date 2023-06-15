var firstRender = true;
var cy;
var cyCfg = {
    style: [
        {
            selector: 'node',
            style: {
                'background-color': '#d7d7d7',
                'label': 'data(id)',
                color: '#ececec',
            }
        },
        {
            selector: 'edge',
            style: {
                'width': 3,
                'line-color': '#ccc',
                'target-arrow-color': '#ccc',
                'target-arrow-shape': 'triangle'
            }
        }
    ],
    layout: {
        name: 'preset'
    },
    wheelSensitivity: .2,
};

window.renderGraph = (elements) => {
    if (firstRender) {
        cyCfg['elements'] = elements;
        cyCfg['container'] = document.getElementById("cy");
        cy = cytoscape(cyCfg);
        firstRender = false;
    } else {
        cy.remove('*');
        cy.add(elements);
    }
}