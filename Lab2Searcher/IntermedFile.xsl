<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
<xsl:template match="read_students">
  <HTML>
    <BODY>
      <TABLE BORDER="2">
        <TR>
            <TD>Name</TD>
            <TD>Faculty</TD>
            <TD>Discipline</TD>
            <TD>Mark</TD>
            <TD>Code</TD>
        </TR>
        <xsl:apply-templates select="student"/>
      </TABLE>
    </BODY>
  </HTML>
</xsl:template>
<xsl:template match="student">
  <TR>
    <TD><xsl:value-of select="name"/></TD>
    <TD><xsl:value-of select="faculty"/></TD>
    <TD><xsl:value-of select="discipline"/></TD>
    <TD><xsl:value-of select="mark"/></TD>
    <TD><xsl:value-of select="code"/></TD>
  </TR>
</xsl:template>
</xsl:stylesheet>