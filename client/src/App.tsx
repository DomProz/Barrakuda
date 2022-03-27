import './App.css';
import Header from './Components/header';
import Categories from './Components/categories';
import Typography from '@mui/material/Typography';
import Navigation from './Components/navigation';
import * as React from 'react';
import Box from '@mui/material/Box';

function App() {
    return (
        <div>
            <header className="App-header">
                <Header />
            </header>
            <section className="App-section">
                <Categories />
            </section>
            <Box className="Box-1"
                sx={{
                    display: 'inline-block',
                    width: '1230px',
                    height: 370,
                    backgroundColor: '#D3D3D3',
                }}
            >Reklamy
            </Box>
            <Box className="Box-2"
                sx={{
                    display: 'inline-block',
                    width: '119px',
                    height: 370,
                    backgroundColor: '#E0FFFF',
                }}
            >Oferty dnia
            </Box>
            <Box className="Box-3"
                sx={{
                    position: 'absolute',
                    display: 'block',
                    width: '100%',
                    height: 350,
                    backgroundColor: '#ADD8E6',
                }}
            >Produkty w promocji
            </Box>
            <footer className="App-footer">
                <Navigation />
            </footer>
    </div>
  );
}
export default App;
