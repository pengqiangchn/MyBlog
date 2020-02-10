<template>
  <!-- <div class="iView">
    <Progress :percent="25" :stroke-width="20" text-inside />
    <Progress :percent="45" :stroke-width="20" status="active" text-inside />
    <Progress :percent="65" :stroke-width="20" status="wrong" text-inside />
    <Progress :percent="100" :stroke-width="20" text-inside />
  </div>-->

  <div>
    <Button>Default</Button>
    <Button type="primary">Primary</Button>
    <Button type="dashed">Dashed</Button>
    <Button type="text">Text</Button>
    <br />
    <br />
    <Button type="info">Info</Button>
    <Button type="success">Success</Button>
    <Button type="warning">Warning</Button>
    <Button type="error">Error</Button>

    <strong>Default Size:</strong>
    <br />
    <br />
    <List header="Header" footer="Footer" border>
      <ListItem>This is a piece of text.</ListItem>
      <ListItem>This is a piece of text.</ListItem>
      <ListItem>This is a piece of text.</ListItem>
    </List>
    <br />
    <strong>Small Size:</strong>
    <br />
    <br />
    <List header="Header" footer="Footer" border size="small">
      <ListItem>This is a piece of text.</ListItem>
      <ListItem>This is a piece of text.</ListItem>
      <ListItem>This is a piece of text.</ListItem>
    </List>
    <br />
    <strong>Large Size:</strong>
    <br />
    <br />
    <List header="Header" footer="Footer" border size="large">
      <ListItem>This is a piece of text.</ListItem>
      <ListItem>This is a piece of text.</ListItem>
      <ListItem>This is a piece of text.</ListItem>
    </List>
    <Row>
      
        <Col span="8">
            <Menu :theme="theme2" :open-names="['1']" accordion>
                <Submenu name="1">
                    <template slot="title">
                        <Icon type="ios-paper" />
                        内容管理
                    </template>
                    <MenuItem name="1-1">文章管理</MenuItem>
                    <MenuItem name="1-2">评论管理</MenuItem>
                    <MenuItem name="1-3">举报管理</MenuItem>
                </Submenu>
                <Submenu name="2">
                    <template slot="title">
                        <Icon type="ios-people" />
                        用户管理
                    </template>
                    <MenuItem name="2-1">新增用户</MenuItem>
                    <MenuItem name="2-2">活跃用户</MenuItem>
                </Submenu>
                <Submenu name="3">
                    <template slot="title">
                        <Icon type="ios-stats" />
                        统计分析
                    </template>
                    <MenuGroup title="使用">
                        <MenuItem name="3-1">新增和启动</MenuItem>
                        <MenuItem name="3-2">活跃分析</MenuItem>
                        <MenuItem name="3-3">时段分析</MenuItem>
                    </MenuGroup>
                    <MenuGroup title="留存">
                        <MenuItem name="3-4">用户留存</MenuItem>
                        <MenuItem name="3-5">流失用户</MenuItem>
                    </MenuGroup>
                </Submenu>
            </Menu>
        </Col>
      <Col span="12">i-col-12</Col>
      <Col span="12">i-col-12</Col>
    </Row>
  </div>
</template>

<script>
  export default {};
</script>

<style>
</style>