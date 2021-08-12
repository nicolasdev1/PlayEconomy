import React, { Component } from 'react'
import { Route } from 'react-router'

import { Layout, Home, Catalog, Inventory } from './components'
import { ApplicationPaths } from './constants'

import './App.css'

class App extends Component {
  static displayName = App.name

  render() {
    return (
      <Layout>
        <Route exact path='/' component={Home} />
        <Route path={ApplicationPaths.CatalogPath} component={Catalog} />
        <Route path={ApplicationPaths.InventoryPath} component={Inventory} />
      </Layout>
    )
  }
}

export default App
