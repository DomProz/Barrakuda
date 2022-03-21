import * as React from 'react';
import List from '@mui/material/List';
import ListItem from '@mui/material/ListItem';
import ListItemText from '@mui/material/ListItemText';
import Divider from '@mui/material/Divider';
import DirectionsCarFilledIcon from '@mui/icons-material/DirectionsCarFilled';
import PaletteIcon from '@mui/icons-material/Palette';
import ElectricalServicesIcon from '@mui/icons-material/ElectricalServices';
import CheckroomIcon from '@mui/icons-material/Checkroom';
import HouseIcon from '@mui/icons-material/House';
import SportsFootballIcon from '@mui/icons-material/SportsFootball';
import ListItemAvatar from '@mui/material/ListItemAvatar';
import Avatar from '@mui/material/Avatar';

const style = {
    width: '170px',
    maxWidth: 1000,
    bgcolor: 'background.paper',
};

export default function Categories() {
    return (
        <List sx={style} component="nav" aria-label="mailbox folders">
            <ListItem button>
                <ListItemAvatar>
                    <Avatar>
                        <DirectionsCarFilledIcon />
                    </Avatar>
                </ListItemAvatar>
                <ListItemText primary="Motoryzacja" />
            </ListItem>
            <Divider />
            <ListItem button divider>
                <ListItemAvatar>
                    <Avatar>
                        <PaletteIcon />
                    </Avatar>
                </ListItemAvatar>
                <ListItemText primary="Kultura" />
            </ListItem>
            <ListItem button>
                <ListItemAvatar>
                    <Avatar>
                        <ElectricalServicesIcon />
                    </Avatar>
                </ListItemAvatar>
                <ListItemText primary="Elektronika" />
            </ListItem>
            <Divider />
            <ListItem button divider>
                <ListItemAvatar>
                    <Avatar>
                        <CheckroomIcon />
                    </Avatar>
                </ListItemAvatar>
                <ListItemText primary="Moda" />
            </ListItem>
            <ListItem button divider>
                <ListItemAvatar>
                    <Avatar>
                        <HouseIcon />
                    </Avatar>
                </ListItemAvatar>
                <ListItemText primary="Dom i ogród" />
            </ListItem>
            <ListItem button divider>
                <ListItemAvatar>
                    <Avatar>
                        <SportsFootballIcon />
                    </Avatar>
                </ListItemAvatar>
                <ListItemText primary="Sport" />
            </ListItem>
        </List>
    );
}