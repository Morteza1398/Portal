import { PortalTemplatePage } from './app.po';

describe('Portal App', function() {
  let page: PortalTemplatePage;

  beforeEach(() => {
    page = new PortalTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
