import React from 'react';
import { Route, Switch } from 'react-router-dom';
import Home from './views/home';
import SignUp from './views/signup';
import NotFound from './components/not-found';
import withAuth from './components/auth/hocs/withAuth';

function Routers(props) {

    // https://stackoverflow.com/questions/43210516/how-to-redirect-from-axios-interceptor-with-react-router-v4
    return (
        <Switch>
            <Route exact path="/" render={() => <Home title="GitRate - Home" />} />
            <Route path="/signup" render={() => <SignUp title="GitRate - SignUp" />} />
            <Route path="/test" component={withAuth(Home, {title: "Protected route"})} />
            <Route render={() => <NotFound title="GitRate - Not Found" />} />
        </Switch>
    )
}

export default Routers;